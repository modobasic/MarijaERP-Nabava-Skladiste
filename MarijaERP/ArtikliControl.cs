using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MarijaERP
{
    public partial class ArtikliControl : UserControl
    {
        public ArtikliControl()
        {
            InitializeComponent();

            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            StilizirajTablicu();
            UcitajArtikle();
            UcitajDobavljace();
        }

        private void StilizirajTablicu()
        {
            dgvArtikli.EnableHeadersVisualStyles = false;
            dgvArtikli.BackgroundColor = Color.White;
            dgvArtikli.BorderStyle = BorderStyle.None;
            dgvArtikli.RowHeadersVisible = false;
            dgvArtikli.AllowUserToAddRows = false;
            dgvArtikli.AllowUserToDeleteRows = false;
            dgvArtikli.ReadOnly = true;
            dgvArtikli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArtikli.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArtikli.GridColor = Color.FromArgb(230, 224, 214);
            dgvArtikli.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvArtikli.ColumnHeadersHeight = 38;
            dgvArtikli.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(243, 240, 232);
            dgvArtikli.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(80, 90, 88);
            dgvArtikli.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            dgvArtikli.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvArtikli.DefaultCellStyle.BackColor = Color.White;
            dgvArtikli.DefaultCellStyle.ForeColor = Color.FromArgb(20, 30, 30);
            dgvArtikli.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 244, 241);
            dgvArtikli.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvArtikli.RowTemplate.Height = 38;
        }

        private void UcitajArtikle()
        {
            dgvArtikli.DataSource = Database.GetData(@"
                SELECT
                    SKU,
                    Naziv,
                    JedinicaMjere AS JM,
                    MinimalnaKolicina AS [MIN.],
                    SigurnosnaKolicina AS [SIG.]
                FROM Artikli
            ");
        }

        private void UcitajDobavljace()
        {
            pnlListaDobavljaca.Controls.Clear();

            DataTable dt = Database.GetData(@"
                SELECT
                    Sifra,
                    Naziv,
                    OIB,
                    Email
                FROM Dobavljaci
            ");

            int y = 0;

            foreach (DataRow row in dt.Rows)
            {
                Panel kartica = new Panel();
                kartica.BackColor = Color.FromArgb(250, 248, 243);
                kartica.BorderStyle = BorderStyle.FixedSingle;
                kartica.Location = new Point(0, y);
                kartica.Size = new Size(pnlListaDobavljaca.Width - 20, 58);

                Label lblNaziv = new Label();
                lblNaziv.Text = row["Sifra"] + " · " + row["Naziv"];
                lblNaziv.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lblNaziv.ForeColor = Color.FromArgb(20, 30, 30);
                lblNaziv.Location = new Point(12, 8);
                lblNaziv.Size = new Size(kartica.Width - 24, 20);

                Label lblDetalji = new Label();
                lblDetalji.Text = row["OIB"] + " · " + row["Email"];
                lblDetalji.Font = new Font("Segoe UI", 8);
                lblDetalji.ForeColor = Color.FromArgb(90, 100, 98);
                lblDetalji.Location = new Point(12, 31);
                lblDetalji.Size = new Size(kartica.Width - 24, 18);

                kartica.Controls.Add(lblNaziv);
                kartica.Controls.Add(lblDetalji);

                pnlListaDobavljaca.Controls.Add(kartica);

                y += 70;
            }
        }

        private void lblA_Click(object sender, EventArgs e)
        {

        }
    }
}