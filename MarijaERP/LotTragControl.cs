using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MarijaERP
{
    public partial class LotTragControl : UserControl
    {
        public LotTragControl()
        {
            InitializeComponent();
            UcitajLotove();
        }

        private void UcitajLotove()
        {
            DataTable dt = Database.GetData(@"
                SELECT
                    l.LotID,
                    'LOT-' + RIGHT('000000000000' + CAST(l.LotID AS varchar), 12) 
                    + ' · ' + a.SKU AS Prikaz
                FROM Lotovi l
                INNER JOIN Artikli a ON l.ArtiklID = a.ArtiklID
                ORDER BY l.DatumZaprimanja DESC, l.LotID DESC
            ");

            cmbLot.DataSource = dt;
            cmbLot.DisplayMember = "Prikaz";
            cmbLot.ValueMember = "LotID";
        }

        private void btnPrikaziTrag_Click(object sender, EventArgs e)
        {
            if (cmbLot.SelectedValue == null)
            {
                MessageBox.Show("Odaberi LOT.");
                return;
            }

            int lotId = Convert.ToInt32(cmbLot.SelectedValue);

            PrikaziTragLota(lotId);
        }

        private void PrikaziTragLota(int lotId)
        {
            pnlKretanjeLota.Controls.Clear();

            int y = 0;

            DataTable osnovno = Database.GetData($@"
                SELECT
                    l.LotID,
                    l.LotBroj,
                    a.SKU,
                    a.Naziv AS Artikl,
                    s.Sifra AS Skladiste,
                    l.DatumZaprimanja,
                    l.RokTrajanja,
                    l.Kolicina,
                    l.NabavnaCijena
                FROM Lotovi l
                INNER JOIN Artikli a ON l.ArtiklID = a.ArtiklID
                INNER JOIN Skladista s ON l.SkladisteID = s.SkladisteID
                WHERE l.LotID = {lotId}
            ");

            if (osnovno.Rows.Count == 0)
                return;

            DataRow lot = osnovno.Rows[0];

            string naslovLota =
                "LOT-" + lotId.ToString("000000000000") +
                " · " + lot["SKU"];

            string opisLota =
                lot["Artikl"] +
                " · " + lot["Skladiste"] +
                " · dobavljački LOT: " + lot["LotBroj"];

            DodajKarticu(
                naslovLota,
                opisLota,
                FontStyle.Bold,
                ref y
            );

            DataTable zaprimanje = Database.GetData($@"
                SELECT TOP 1
                    z.DatumZaprimanja,
                    z.Kolicina,
                    z.Otpremnica,
                    z.Zaprimio
                FROM Zaprimanja z
                WHERE z.LotID = {lotId}
                ORDER BY z.DatumZaprimanja ASC
            ");

            if (zaprimanje.Rows.Count > 0)
            {
                DataRow z = zaprimanje.Rows[0];

                DodajKarticu(
                    "Zaprimanje",
                    Convert.ToDateTime(z["DatumZaprimanja"]).ToString("dd.MM.yyyy. HH:mm") +
                    " | zaprimljeno: " + Convert.ToDecimal(z["Kolicina"]).ToString("N0") +
                    " | otpremnica: " + z["Otpremnica"] +
                    " | zaprimio/la: " + z["Zaprimio"],
                    FontStyle.Bold,
                    ref y
                );
            }
            else
            {
                DodajKarticu(
                    "Početno stanje",
                    Convert.ToDateTime(lot["DatumZaprimanja"]).ToString("dd.MM.yyyy.") +
                    " | dostupno: " + Convert.ToDecimal(lot["Kolicina"]).ToString("N0") +
                    " | cijena: " + Convert.ToDecimal(lot["NabavnaCijena"]).ToString("N2") + " €",
                    FontStyle.Bold,
                    ref y
                );
            }

            DataTable izlazi = Database.GetData($@"
                SELECT
                    Datum,
                    Kolicina,
                    Napomena
                FROM PrometZaliha
                WHERE LotID = {lotId}
                  AND VrstaPrometa = 'IZLAZ'
                ORDER BY Datum ASC
            ");

            foreach (DataRow izlaz in izlazi.Rows)
            {
                DodajKarticu(
                    "FIFO izdavanje",
                    Convert.ToDateTime(izlaz["Datum"]).ToString("dd.MM.yyyy. HH:mm") +
                    " | izdano: " + Convert.ToDecimal(izlaz["Kolicina"]).ToString("N0") +
                    " | " + izlaz["Napomena"],
                    FontStyle.Bold,
                    ref y
                );
            }

            if (izlazi.Rows.Count == 0)
            {
                DodajKarticu(
                    "Izdavanja",
                    "Za ovaj LOT još nema FIFO izdavanja.",
                    FontStyle.Regular,
                    ref y
                );
            }
        }

        private void DodajKarticu(string naslov, string opis, FontStyle stilNaslova, ref int y)
        {
            Panel kartica = new Panel();
            kartica.BackColor = Color.FromArgb(250, 248, 243);
            kartica.BorderStyle = BorderStyle.FixedSingle;
            kartica.Location = new Point(0, y);
            kartica.Size = new Size(pnlKretanjeLota.Width - 20, 62);

            Label lblNaslov = new Label();
            lblNaslov.Text = naslov;
            lblNaslov.Font = new Font("Segoe UI", 9, stilNaslova);
            lblNaslov.ForeColor = Color.FromArgb(20, 30, 30);
            lblNaslov.Location = new Point(12, 8);
            lblNaslov.Size = new Size(kartica.Width - 24, 20);

            Label lblOpis = new Label();
            lblOpis.Text = opis;
            lblOpis.Font = new Font("Segoe UI", 8);
            lblOpis.ForeColor = Color.FromArgb(90, 100, 98);
            lblOpis.Location = new Point(12, 32);
            lblOpis.Size = new Size(kartica.Width - 24, 20);

            kartica.Controls.Add(lblNaslov);
            kartica.Controls.Add(lblOpis);

            pnlKretanjeLota.Controls.Add(kartica);

            y += 72;
        }
    }
}