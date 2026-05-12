using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace MarijaERP
{
    public partial class NarudzbeControl : UserControl
    {
        public NarudzbeControl()
        {
            InitializeComponent();
            UcitajSve();
        }

        private void UcitajSve()
        {
            StilizirajTablicu();
            UcitajDobavljace();
            UcitajArtikle();
            UcitajNarudzbe();
        }

        private void StilizirajTablicu()
        {
            dgvNarudzbe.EnableHeadersVisualStyles = false;
            dgvNarudzbe.BackgroundColor = Color.White;
            dgvNarudzbe.BorderStyle = BorderStyle.None;
            dgvNarudzbe.RowHeadersVisible = false;
            dgvNarudzbe.AllowUserToAddRows = false;
            dgvNarudzbe.AllowUserToDeleteRows = false;
            dgvNarudzbe.ReadOnly = true;

            dgvNarudzbe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvNarudzbe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNarudzbe.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvNarudzbe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNarudzbe.GridColor = Color.FromArgb(230, 224, 214);
            dgvNarudzbe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvNarudzbe.ColumnHeadersHeight = 38;
            dgvNarudzbe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(243, 240, 232);
            dgvNarudzbe.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 90, 88);
            dgvNarudzbe.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            dgvNarudzbe.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvNarudzbe.DefaultCellStyle.BackColor = Color.White;
            dgvNarudzbe.DefaultCellStyle.ForeColor = Color.FromArgb(20, 30, 30);

            dgvNarudzbe.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(232, 244, 241);

            dgvNarudzbe.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvNarudzbe.RowTemplate.Height = 70;

            dgvNarudzbe.DataBindingComplete += (s, e) =>
            {
                dgvNarudzbe.Columns["BROJ"].Width = 140;
                dgvNarudzbe.Columns["DATUM"].Width = 120;
                dgvNarudzbe.Columns["DOBAVLJAČ"].Width = 200;
                dgvNarudzbe.Columns["STATUS"].Width = 170;
                dgvNarudzbe.Columns["STAVKE"].Width = 220;
                dgvNarudzbe.Columns["VRIJEDNOST"].Width = 110;

                dgvNarudzbe.Columns["VRIJEDNOST"].DefaultCellStyle.Format = "N2";
            };
        }

        private void UcitajDobavljace()
        {
            DataTable dt = Database.GetData(@"
                SELECT 
                    DobavljacID,
                    Sifra + ' · ' + Naziv AS Prikaz
                FROM Dobavljaci
            ");

            cmbDobavljac.DataSource = dt;
            cmbDobavljac.DisplayMember = "Prikaz";
            cmbDobavljac.ValueMember = "DobavljacID";
        }

        private void UcitajArtikle()
        {
            DataTable dt = Database.GetData(@"
                SELECT 
                    ArtiklID,
                    SKU + ' · ' + Naziv AS Prikaz
                FROM Artikli
            ");

            cmbArtikl.DataSource = dt;
            cmbArtikl.DisplayMember = "Prikaz";
            cmbArtikl.ValueMember = "ArtiklID";
        }

        private void UcitajNarudzbe()
        {
            dgvNarudzbe.DataSource = Database.GetData(@"
                SELECT
                    n.Broj AS BROJ,
                    CONVERT(varchar, n.Datum, 104) AS DATUM,
                    d.Naziv AS DOBAVLJAČ,
                    n.Status AS STATUS,
                    STRING_AGG(
                        a.SKU + ': ' + 
                        CAST(CAST(ns.Kolicina - ns.Zaprimljeno AS int) AS varchar) + 
                        ' otvoreno', CHAR(10)
                    ) AS STAVKE,
                    CAST(SUM((ns.Kolicina - ns.Zaprimljeno) * ns.Cijena) AS DECIMAL(18,2)) AS VRIJEDNOST
                FROM Narudzbenice n
                INNER JOIN Dobavljaci d ON n.DobavljacID = d.DobavljacID
                INNER JOIN NarudzbenicaStavke ns ON n.NarudzbenicaID = ns.NarudzbenicaID
                INNER JOIN Artikli a ON ns.ArtiklID = a.ArtiklID
                WHERE n.Status <> 'Zatvoreno'
                  AND (ns.Kolicina - ns.Zaprimljeno) > 0
                GROUP BY n.Broj, n.Datum, d.Naziv, n.Status
                ORDER BY n.Datum DESC
            ");
        }

        private void btnKreirajNarudzbu_Click(object sender, EventArgs e)
        {
            if (cmbDobavljac.SelectedValue == null || cmbArtikl.SelectedValue == null)
            {
                MessageBox.Show("Odaberi dobavljača i artikl.");
                return;
            }

            if (!decimal.TryParse(txtKolicina.Text, out decimal kolicina) || kolicina <= 0)
            {
                MessageBox.Show("Unesi ispravnu količinu.");
                return;
            }

            if (!decimal.TryParse(txtCijena.Text, out decimal cijena) || cijena <= 0)
            {
                MessageBox.Show("Unesi ispravnu cijenu.");
                return;
            }

            int dobavljacId = Convert.ToInt32(cmbDobavljac.SelectedValue);
            int artiklId = Convert.ToInt32(cmbArtikl.SelectedValue);

            string broj = "PO-" + DateTime.Now.Year + "-" + DateTime.Now.ToString("MMddHHmmss");

            string kolicinaSql = kolicina.ToString(CultureInfo.InvariantCulture);
            string cijenaSql = cijena.ToString(CultureInfo.InvariantCulture);

            Database.Execute($@"
                INSERT INTO Narudzbenice 
                (Broj, DobavljacID, Datum, OcekivaniDatum, Status)
                VALUES 
                ('{broj}', {dobavljacId}, GETDATE(), '{dtpOcekivaniDatum.Value:yyyy-MM-dd}', 'Odobreno')
            ");

            DataTable dt = Database.GetData($@"
                SELECT NarudzbenicaID
                FROM Narudzbenice
                WHERE Broj = '{broj}'
            ");

            int narudzbenicaId = Convert.ToInt32(dt.Rows[0]["NarudzbenicaID"]);

            Database.Execute($@"
                INSERT INTO NarudzbenicaStavke
                (NarudzbenicaID, ArtiklID, Kolicina, Cijena, Zaprimljeno)
                VALUES
                ({narudzbenicaId}, {artiklId}, {kolicinaSql}, {cijenaSql}, 0)
            ");

            MessageBox.Show("Narudžbenica je kreirana.");

            txtKolicina.Clear();
            txtCijena.Clear();

            UcitajNarudzbe();
        }
    }
}