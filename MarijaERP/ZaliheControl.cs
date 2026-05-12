using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace MarijaERP
{
    public partial class ZaliheControl : UserControl
    {
        public ZaliheControl()
        {
            InitializeComponent();
            UcitajSve();
        }

        private void UcitajSve()
        {
            StilizirajTablicu();
            UcitajArtikle();
            UcitajSkladista();
            UcitajLotove();
        }

        private void StilizirajTablicu()
        {
            dgvLotovi.EnableHeadersVisualStyles = false;
            dgvLotovi.BackgroundColor = Color.White;
            dgvLotovi.BorderStyle = BorderStyle.None;
            dgvLotovi.RowHeadersVisible = false;
            dgvLotovi.AllowUserToAddRows = false;
            dgvLotovi.AllowUserToDeleteRows = false;
            dgvLotovi.ReadOnly = true;
            dgvLotovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLotovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLotovi.GridColor = Color.FromArgb(230, 224, 214);
            dgvLotovi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvLotovi.ColumnHeadersHeight = 38;
            dgvLotovi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(243, 240, 232);
            dgvLotovi.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 90, 88);
            dgvLotovi.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            dgvLotovi.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvLotovi.DefaultCellStyle.BackColor = Color.White;
            dgvLotovi.DefaultCellStyle.ForeColor = Color.FromArgb(20, 30, 30);
            dgvLotovi.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 244, 241);
            dgvLotovi.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvLotovi.RowTemplate.Height = 42;
        }

        private void UcitajArtikle()
        {
            DataTable dt = Database.GetData(@"
                SELECT 
                    ArtiklID,
                    SKU + ' · ' + Naziv AS Prikaz
                FROM Artikli
                ORDER BY SKU
            ");

            cmbArtiklFifo.DataSource = dt;
            cmbArtiklFifo.DisplayMember = "Prikaz";
            cmbArtiklFifo.ValueMember = "ArtiklID";
        }

        private void UcitajSkladista()
        {
            DataTable dt = Database.GetData(@"
                SELECT 
                    SkladisteID,
                    Sifra + ' · ' + Naziv AS Prikaz
                FROM Skladista
                ORDER BY Sifra
            ");

            cmbSkladisteFifo.DataSource = dt;
            cmbSkladisteFifo.DisplayMember = "Prikaz";
            cmbSkladisteFifo.ValueMember = "SkladisteID";
        }

        private void UcitajLotove()
        {
            dgvLotovi.DataSource = Database.GetData(@"
                SELECT
                    'LOT-' + RIGHT('000000000000' + CAST(l.LotID AS varchar), 12) AS LOT,
                    l.LotBroj AS [LOT dobavljača],
                    a.SKU,
                    CONVERT(varchar, l.DatumZaprimanja, 104) AS Zaprimljen,
                    CAST(l.Kolicina AS DECIMAL(18,0)) AS Dostupno,
                    CAST(l.NabavnaCijena AS DECIMAL(18,2)) AS Cijena
                FROM Lotovi l
                INNER JOIN Artikli a ON l.ArtiklID = a.ArtiklID
                WHERE l.Kolicina > 0
                ORDER BY l.DatumZaprimanja ASC, l.LotID ASC
            ");
        }

        private void btnIzdajFifo_Click(object sender, EventArgs e)
        {
            if (cmbArtiklFifo.SelectedValue == null || cmbSkladisteFifo.SelectedValue == null)
            {
                MessageBox.Show("Odaberi artikl i skladište.");
                return;
            }

            if (!decimal.TryParse(txtKolicinaIzdavanja.Text, out decimal trazenaKolicina) || trazenaKolicina <= 0)
            {
                MessageBox.Show("Unesi ispravnu količinu.");
                return;
            }

            int artiklId = Convert.ToInt32(cmbArtiklFifo.SelectedValue);
            int skladisteId = Convert.ToInt32(cmbSkladisteFifo.SelectedValue);

            DataTable lotovi = Database.GetData($@"
                SELECT LotID, Kolicina
                FROM Lotovi
                WHERE ArtiklID = {artiklId}
                  AND SkladisteID = {skladisteId}
                  AND Kolicina > 0
                ORDER BY DatumZaprimanja ASC, LotID ASC
            ");

            decimal dostupnoUkupno = 0;

            foreach (DataRow red in lotovi.Rows)
            {
                dostupnoUkupno += Convert.ToDecimal(red["Kolicina"]);
            }

            if (dostupnoUkupno < trazenaKolicina)
            {
                MessageBox.Show("Nema dovoljno zalihe za FIFO izdavanje.");
                return;
            }

            decimal preostaloZaIzdati = trazenaKolicina;

            foreach (DataRow red in lotovi.Rows)
            {
                if (preostaloZaIzdati <= 0)
                    break;

                int lotId = Convert.ToInt32(red["LotID"]);
                decimal dostupnoNaLotu = Convert.ToDecimal(red["Kolicina"]);
                decimal izdajeSe = Math.Min(preostaloZaIzdati, dostupnoNaLotu);

                string izdajeSeSql = izdajeSe.ToString(CultureInfo.InvariantCulture);

                Database.Execute($@"
                    UPDATE Lotovi
                    SET Kolicina = Kolicina - {izdajeSeSql}
                    WHERE LotID = {lotId}
                ");

                string napomena =
                    txtRazlog.Text.Replace("'", "''") +
                    " · izdao/la: " +
                    txtIzdao.Text.Replace("'", "''");

                Database.Execute($@"
                    INSERT INTO PrometZaliha
                    (LotID, VrstaPrometa, Kolicina, Napomena)
                    VALUES
                    ({lotId}, 'IZLAZ', {izdajeSeSql}, '{napomena}')
                ");

                preostaloZaIzdati -= izdajeSe;
            }

            MessageBox.Show("FIFO izdavanje je uspješno provedeno.");

            txtKolicinaIzdavanja.Clear();

            UcitajLotove();
        }
    }
}