using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MarijaERP
{
    public partial class IzvjestajiControl : UserControl
    {
        public IzvjestajiControl()
        {
            InitializeComponent();
            UcitajSve();
        }

        private void UcitajSve()
        {
            StilizirajTablicu();
            UcitajOtvoreneStavke();
            UcitajVrijednostPoKategoriji();
        }

        private void StilizirajTablicu()
        {
            dgvOtvoreneStavke.EnableHeadersVisualStyles = false;
            dgvOtvoreneStavke.BackgroundColor = Color.White;
            dgvOtvoreneStavke.BorderStyle = BorderStyle.None;
            dgvOtvoreneStavke.RowHeadersVisible = false;
            dgvOtvoreneStavke.AllowUserToAddRows = false;
            dgvOtvoreneStavke.AllowUserToDeleteRows = false;
            dgvOtvoreneStavke.ReadOnly = true;
            dgvOtvoreneStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOtvoreneStavke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOtvoreneStavke.GridColor = Color.FromArgb(230, 224, 214);
            dgvOtvoreneStavke.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvOtvoreneStavke.ColumnHeadersHeight = 38;
            dgvOtvoreneStavke.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(243, 240, 232);
            dgvOtvoreneStavke.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 90, 88);
            dgvOtvoreneStavke.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            dgvOtvoreneStavke.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvOtvoreneStavke.DefaultCellStyle.BackColor = Color.White;
            dgvOtvoreneStavke.DefaultCellStyle.ForeColor = Color.FromArgb(20, 30, 30);
            dgvOtvoreneStavke.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 244, 241);
            dgvOtvoreneStavke.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvOtvoreneStavke.RowTemplate.Height = 42;
        }

        private void UcitajOtvoreneStavke()
        {
            dgvOtvoreneStavke.DataSource = Database.GetData(@"
                SELECT
                    n.Broj AS PO,
                    CONVERT(varchar, n.OcekivaniDatum, 104) AS Datum,
                    a.SKU + ' · ' + a.Naziv AS Artikl,
                    d.Naziv AS Dobavljač,
                    CAST(ns.Kolicina - ns.Zaprimljeno AS DECIMAL(18,0)) AS Otvoreno,
                    CAST((ns.Kolicina - ns.Zaprimljeno) * ns.Cijena AS DECIMAL(18,2)) AS Vrijednost
                FROM NarudzbenicaStavke ns
                INNER JOIN Narudzbenice n ON ns.NarudzbenicaID = n.NarudzbenicaID
                INNER JOIN Artikli a ON ns.ArtiklID = a.ArtiklID
                INNER JOIN Dobavljaci d ON n.DobavljacID = d.DobavljacID
                WHERE n.Status <> 'Zatvoreno'
                  AND (ns.Kolicina - ns.Zaprimljeno) > 0
                ORDER BY n.OcekivaniDatum ASC
            ");
        }

        private void UcitajVrijednostPoKategoriji()
        {
            pnlVrijednostKategorije.Controls.Clear();

            DataTable dt = Database.GetData(@"
                SELECT
                    LEFT(a.SKU, 3) AS Kategorija,
                    s.Sifra AS Skladiste,
                    CAST(SUM(l.Kolicina) AS DECIMAL(18,0)) AS Kolicina,
                    CAST(SUM(l.Kolicina * l.NabavnaCijena) AS DECIMAL(18,2)) AS Vrijednost
                FROM Lotovi l
                INNER JOIN Artikli a ON l.ArtiklID = a.ArtiklID
                INNER JOIN Skladista s ON l.SkladisteID = s.SkladisteID
                WHERE l.Kolicina > 0
                GROUP BY LEFT(a.SKU, 3), s.Sifra
                ORDER BY Vrijednost DESC
            ");

            decimal maxVrijednost = 1;

            foreach (DataRow red in dt.Rows)
            {
                decimal vrijednost = Convert.ToDecimal(red["Vrijednost"]);

                if (vrijednost > maxVrijednost)
                    maxVrijednost = vrijednost;
            }

            int y = 0;

            foreach (DataRow red in dt.Rows)
            {
                string kategorija = red["Kategorija"]?.ToString() ?? "";
                string skladiste = red["Skladiste"]?.ToString() ?? "";
                decimal kolicina = Convert.ToDecimal(red["Kolicina"]);
                decimal vrijednost = Convert.ToDecimal(red["Vrijednost"]);

                Panel kartica = new Panel();
                kartica.BackColor = Color.FromArgb(250, 248, 243);
                kartica.BorderStyle = BorderStyle.FixedSingle;
                kartica.Location = new Point(0, y);
                kartica.Size = new Size(pnlVrijednostKategorije.Width - 20, 72);

                Label lblNaslov = new Label();
                lblNaslov.Text = kategorija + " · " + skladiste + " · " + vrijednost.ToString("N2") + " €";
                lblNaslov.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lblNaslov.ForeColor = Color.FromArgb(20, 30, 30);
                lblNaslov.Location = new Point(12, 10);
                lblNaslov.Size = new Size(kartica.Width - 24, 20);

                Label lblOpis = new Label();
                lblOpis.Text = kolicina.ToString("N0") + " jedinica na zalihi";
                lblOpis.Font = new Font("Segoe UI", 8);
                lblOpis.ForeColor = Color.FromArgb(90, 100, 98);
                lblOpis.Location = new Point(12, 32);
                lblOpis.Size = new Size(kartica.Width - 24, 18);

                Panel linijaPozadina = new Panel();
                linijaPozadina.BackColor = Color.FromArgb(230, 224, 214);
                linijaPozadina.Location = new Point(12, 55);
                linijaPozadina.Size = new Size(kartica.Width - 24, 6);

                Panel linijaVrijednost = new Panel();
                linijaVrijednost.BackColor = Color.FromArgb(0, 128, 112);
                linijaVrijednost.Location = new Point(0, 0);

                int sirina = (int)((vrijednost / maxVrijednost) * linijaPozadina.Width);

                if (sirina < 10)
                    sirina = 10;

                linijaVrijednost.Size = new Size(sirina, 6);

                linijaPozadina.Controls.Add(linijaVrijednost);

                kartica.Controls.Add(lblNaslov);
                kartica.Controls.Add(lblOpis);
                kartica.Controls.Add(linijaPozadina);

                pnlVrijednostKategorije.Controls.Add(kartica);

                y += 85;
            }
        }
    }
}