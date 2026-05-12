using System;
using System.Drawing;
using System.Windows.Forms;

namespace MarijaERP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            PrikaziEkran(new PregledControl());
            OznaciAktivniGumb(btnPregled);
        }

        private void PrikaziEkran(UserControl ekran)
        {
            pnlMain.Controls.Clear();
            ekran.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ekran);
        }

        private void ResetirajGumbe()
        {
            Button[] gumbi =
            {
                btnPregled,
                btnArtikli,
                btnNarudzbe,
                btnZaprimanje,
                btnZalihe,
                btnIzvjestaji,
                btnLotTrag
            };

            foreach (Button gumb in gumbi)
            {
                gumb.BackColor = Color.FromArgb(22, 35, 31);
                gumb.ForeColor = Color.White;
                gumb.FlatStyle = FlatStyle.Flat;
                gumb.FlatAppearance.BorderSize = 0;
            }
        }

        private void OznaciAktivniGumb(Button aktivniGumb)
        {
            ResetirajGumbe();
            aktivniGumb.BackColor = Color.FromArgb(48, 63, 58);
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            PrikaziEkran(new PregledControl());
            OznaciAktivniGumb(btnPregled);
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            PrikaziEkran(new ArtikliControl());
            OznaciAktivniGumb(btnArtikli);
        }

        private void btnNarudzbe_Click(object sender, EventArgs e)
        {
            PrikaziEkran(new NarudzbeControl());
            OznaciAktivniGumb(btnNarudzbe);
        }

        private void btnZaprimanje_Click(object sender, EventArgs e)
        {
            PrikaziEkran(new ZaprimanjeControl());
            OznaciAktivniGumb(btnZaprimanje);
        }

        private void btnZalihe_Click(object sender, EventArgs e)
        {
            PrikaziEkran(new ZaliheControl());
            OznaciAktivniGumb(btnZalihe);
        }

        private void btnIzvjestaji_Click(object sender, EventArgs e)
        {
            PrikaziEkran(new IzvjestajiControl());
            OznaciAktivniGumb(btnIzvjestaji);
        }

        private void btnLotTrag_Click(object sender, EventArgs e)
        {
            PrikaziEkran(new LotTragControl());
            OznaciAktivniGumb(btnLotTrag);
        }

       
    }
}