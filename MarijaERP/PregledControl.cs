using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MarijaERP
{
    public partial class PregledControl : UserControl
    {
        public PregledControl()
        {
            InitializeComponent();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            StilizirajTablicu();
            UcitajKartice();
            UcitajTablicu();
            UcitajUpozorenja();
        }

        private void StilizirajTablicu()
        {
            dgvPregled.EnableHeadersVisualStyles = false;
            dgvPregled.BackgroundColor = Color.White;
            dgvPregled.BorderStyle = BorderStyle.None;
            dgvPregled.RowHeadersVisible = false;
            dgvPregled.AllowUserToAddRows = false;
            dgvPregled.AllowUserToDeleteRows = false;
            dgvPregled.ReadOnly = true;
            dgvPregled.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPregled.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPregled.GridColor = Color.FromArgb(230, 224, 214);
            dgvPregled.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvPregled.ColumnHeadersHeight = 38;
            dgvPregled.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(243, 240, 232);
            dgvPregled.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 90, 88);
            dgvPregled.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            dgvPregled.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvPregled.DefaultCellStyle.BackColor = Color.White;
            dgvPregled.DefaultCellStyle.ForeColor = Color.FromArgb(20, 30, 30);
            dgvPregled.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 244, 241);
            dgvPregled.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvPregled.RowTemplate.Height = 38;
        }

        private void UcitajKartice()
        {
            DataTable dt = Database.GetData(@"
                SELECT
                    ISNULL(SUM(Kolicina * NabavnaCijena), 0) AS VrijednostZalihe,
                    ISNULL(SUM(Kolicina), 0) AS UkupnaKolicina,
                    COUNT(*) AS BrojLotova
                FROM Lotovi
            ");

            lblVrijednostZalihe.Text =
                Convert.ToDecimal(dt.Rows[0]["VrijednostZalihe"]).ToString("N2") + " €";

            lblUkupnaKolicina.Text =
                Convert.ToDecimal(dt.Rows[0]["UkupnaKolicina"]).ToString("N0");

            if (Controls.Find("lblBrojLotova", true).Length > 0)
            {
                Controls.Find("lblBrojLotova", true)[0].Text =
                    dt.Rows[0]["BrojLotova"] + " aktivnih LOT slojeva";
            }

            DataTable dtNiska = Database.GetData(@"
                SELECT COUNT(*) AS Broj
                FROM Artikli a
                WHERE (
                    SELECT ISNULL(SUM(l.Kolicina), 0)
                    FROM Lotovi l
                    WHERE l.ArtiklID = a.ArtiklID
                ) < a.SigurnosnaKolicina
            ");

            lblNiskaZaliha.Text = dtNiska.Rows[0]["Broj"].ToString();

            DataTable dtNabava = Database.GetData(@"
                SELECT ISNULL(SUM((ns.Kolicina - ns.Zaprimljeno) * ns.Cijena), 0) AS OtvorenaNabava
                FROM NarudzbenicaStavke ns
                INNER JOIN Narudzbenice n ON ns.NarudzbenicaID = n.NarudzbenicaID
                WHERE n.Status <> 'Zatvoreno'
                  AND (ns.Kolicina - ns.Zaprimljeno) > 0
            ");

            lblOtvorenaNabava.Text =
                Convert.ToDecimal(dtNabava.Rows[0]["OtvorenaNabava"]).ToString("N2") + " €";
        }

        private void UcitajTablicu()
        {
            dgvPregled.DataSource = Database.GetData(@"
                SELECT 
                    a.SKU,
                    a.Naziv AS Artikl,
                    s.Sifra AS Skladište,
                    CAST(SUM(l.Kolicina) AS DECIMAL(18,0)) AS Količina,
                    CAST(SUM(l.Kolicina * l.NabavnaCijena) AS DECIMAL(18,2)) AS Vrijednost,
                    COUNT(l.LotID) AS LOT
                FROM Lotovi l
                INNER JOIN Artikli a ON l.ArtiklID = a.ArtiklID
                INNER JOIN Skladista s ON l.SkladisteID = s.SkladisteID
                GROUP BY a.SKU, a.Naziv, s.Sifra
            ");
        }

        private void UcitajUpozorenja()
        {
            pnlListaUpozorenja.Controls.Clear();

            DataTable dt = Database.GetData(@"
        SELECT 
            a.SKU,
            a.Naziv,
            a.SigurnosnaKolicina,
            ISNULL(SUM(l.Kolicina), 0) AS Trenutno
        FROM Artikli a
        LEFT JOIN Lotovi l ON a.ArtiklID = l.ArtiklID
        GROUP BY a.SKU, a.Naziv, a.SigurnosnaKolicina
        HAVING ISNULL(SUM(l.Kolicina), 0) < a.SigurnosnaKolicina
    ");

            int y = 0;

            foreach (DataRow row in dt.Rows)
            {
                Panel kartica = new Panel();
                kartica.BackColor = Color.FromArgb(250, 248, 243);
                kartica.BorderStyle = BorderStyle.FixedSingle;
                kartica.Location = new Point(0, y);
                kartica.Size = new Size(pnlListaUpozorenja.Width - 20, 58);

                Label naslov = new Label();
                naslov.Text = row["SKU"] + " · " + row["Naziv"];
                naslov.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                naslov.ForeColor = Color.FromArgb(20, 30, 30);
                naslov.AutoSize = false;
                naslov.Location = new Point(12, 8);
                naslov.Size = new Size(kartica.Width - 24, 20);

                Label opis = new Label();
                opis.Text =
                    "Trenutno: " + Convert.ToDecimal(row["Trenutno"]).ToString("N0") +
                    " | predloženo naručiti: " +
                    Convert.ToDecimal(row["SigurnosnaKolicina"]).ToString("N0");

                opis.Font = new Font("Segoe UI", 8);
                opis.ForeColor = Color.FromArgb(90, 100, 98);
                opis.AutoSize = false;
                opis.Location = new Point(12, 31);
                opis.Size = new Size(kartica.Width - 24, 18);

                kartica.Controls.Add(naslov);
                kartica.Controls.Add(opis);

                pnlListaUpozorenja.Controls.Add(kartica);

                y += 70;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}