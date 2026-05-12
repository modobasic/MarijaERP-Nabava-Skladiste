using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace MarijaERP
{
    public partial class ZaprimanjeControl : UserControl
    {
        public ZaprimanjeControl()
        {
            InitializeComponent();
            UcitajSve();
        }

        private void UcitajSve()
        {
            UcitajNarudzbenice();
            UcitajSkladista();
            UcitajPovijest();
        }

        private void UcitajNarudzbenice()
        {
            DataTable dt = Database.GetData(@"
                SELECT 
                    n.NarudzbenicaID,
                    n.Broj + ' · ' + d.Naziv AS Prikaz
                FROM Narudzbenice n
                INNER JOIN Dobavljaci d ON n.DobavljacID = d.DobavljacID
                WHERE n.Status <> 'Zatvoreno'
                ORDER BY n.Datum DESC
            ");

            cmbNarudzbenica.DataSource = dt;
            cmbNarudzbenica.DisplayMember = "Prikaz";
            cmbNarudzbenica.ValueMember = "NarudzbenicaID";

            UcitajStavke();
        }

        private void UcitajStavke()
        {
            if (cmbNarudzbenica.SelectedValue == null)
                return;

            int narudzbenicaId = Convert.ToInt32(cmbNarudzbenica.SelectedValue);

            DataTable dt = Database.GetData($@"
                SELECT 
                    ns.StavkaID,
                    a.SKU + ' · otvoreno ' + 
                    CAST(CAST(ns.Kolicina - ns.Zaprimljeno AS int) AS varchar) AS Prikaz,
                    ns.Cijena
                FROM NarudzbenicaStavke ns
                INNER JOIN Artikli a ON ns.ArtiklID = a.ArtiklID
                WHERE ns.NarudzbenicaID = {narudzbenicaId}
                  AND (ns.Kolicina - ns.Zaprimljeno) > 0
            ");

            cmbStavka.DataSource = dt;
            cmbStavka.DisplayMember = "Prikaz";
            cmbStavka.ValueMember = "StavkaID";

            if (dt.Rows.Count > 0)
                txtNabavnaCijena.Text = Convert.ToDecimal(dt.Rows[0]["Cijena"]).ToString("N2");
        }

        private void UcitajSkladista()
        {
            DataTable dt = Database.GetData(@"
                SELECT 
                    SkladisteID,
                    Sifra + ' · ' + Naziv AS Prikaz
                FROM Skladista
            ");

            cmbSkladiste.DataSource = dt;
            cmbSkladiste.DisplayMember = "Prikaz";
            cmbSkladiste.ValueMember = "SkladisteID";
        }

        private void cmbNarudzbenica_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStavke();
        }

        private void btnZaprimiRobu_Click(object sender, EventArgs e)
        {
            if (cmbNarudzbenica.SelectedValue == null || cmbStavka.SelectedValue == null || cmbSkladiste.SelectedValue == null)
            {
                MessageBox.Show("Odaberi narudžbenicu, stavku i skladište.");
                return;
            }

            if (!decimal.TryParse(txtKolicinaZaprimanja.Text, out decimal kolicina) || kolicina <= 0)
            {
                MessageBox.Show("Unesi ispravnu količinu.");
                return;
            }

            if (!decimal.TryParse(txtNabavnaCijena.Text, out decimal cijena) || cijena <= 0)
            {
                MessageBox.Show("Unesi ispravnu nabavnu cijenu.");
                return;
            }

            int narudzbenicaId = Convert.ToInt32(cmbNarudzbenica.SelectedValue);
            int stavkaId = Convert.ToInt32(cmbStavka.SelectedValue);
            int skladisteId = Convert.ToInt32(cmbSkladiste.SelectedValue);

            DataTable stavka = Database.GetData($@"
                SELECT ArtiklID, Kolicina, Zaprimljeno
                FROM NarudzbenicaStavke
                WHERE StavkaID = {stavkaId}
            ");

            int artiklId = Convert.ToInt32(stavka.Rows[0]["ArtiklID"]);
            decimal naruceno = Convert.ToDecimal(stavka.Rows[0]["Kolicina"]);
            decimal vecZaprimljeno = Convert.ToDecimal(stavka.Rows[0]["Zaprimljeno"]);
            decimal otvoreno = naruceno - vecZaprimljeno;

            if (kolicina > otvoreno)
            {
                MessageBox.Show("Ne možeš zaprimiti više od otvorene količine.");
                return;
            }

            string lotBroj = "LOT-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
            string kolicinaSql = kolicina.ToString(CultureInfo.InvariantCulture);
            string cijenaSql = cijena.ToString(CultureInfo.InvariantCulture);

            Database.Execute($@"
                INSERT INTO Lotovi
                (LotBroj, ArtiklID, SkladisteID, DatumZaprimanja, RokTrajanja, Kolicina, NabavnaCijena)
                VALUES
                ('{lotBroj}', {artiklId}, {skladisteId}, GETDATE(), '{dtpRokTrajanja.Value:yyyy-MM-dd}', {kolicinaSql}, {cijenaSql})
            ");

            DataTable noviLot = Database.GetData($@"
                SELECT LotID
                FROM Lotovi
                WHERE LotBroj = '{lotBroj}'
            ");

            int lotId = Convert.ToInt32(noviLot.Rows[0]["LotID"]);

            Database.Execute($@"
                INSERT INTO Zaprimanja
                (NarudzbenicaID, StavkaID, SkladisteID, LotID, Otpremnica, LotDobavljaca, Kolicina, NabavnaCijena, Zaprimio)
                VALUES
                ({narudzbenicaId}, {stavkaId}, {skladisteId}, {lotId},
                '{txtOtpremnica.Text}', '{txtLotDobavljaca.Text}', {kolicinaSql}, {cijenaSql}, '{txtZaprimio.Text}')
            ");

            Database.Execute($@"
                UPDATE NarudzbenicaStavke
                SET Zaprimljeno = Zaprimljeno + {kolicinaSql}
                WHERE StavkaID = {stavkaId}
            ");

            Database.Execute($@"
                UPDATE Narudzbenice
                SET Status =
                    CASE
                        WHEN NOT EXISTS (
                            SELECT 1
                            FROM NarudzbenicaStavke
                            WHERE NarudzbenicaID = {narudzbenicaId}
                              AND Kolicina > Zaprimljeno
                        )
                        THEN 'Zatvoreno'
                        ELSE 'Djelomično zaprimljeno'
                    END
                WHERE NarudzbenicaID = {narudzbenicaId}
            ");

            MessageBox.Show("Roba je zaprimljena i LOT je kreiran.");

            txtKolicinaZaprimanja.Clear();
            txtOtpremnica.Clear();
            txtLotDobavljaca.Clear();

            UcitajNarudzbenice();
            UcitajPovijest();
        }

        private void UcitajPovijest()
        {
            pnlPovijestZaprimanja.Controls.Clear();

            DataTable dt = Database.GetData(@"
                SELECT TOP 10
                    z.DatumZaprimanja,
                    n.Broj,
                    s.Sifra AS Skladiste,
                    z.Kolicina,
                    z.Zaprimio
                FROM Zaprimanja z
                INNER JOIN Narudzbenice n ON z.NarudzbenicaID = n.NarudzbenicaID
                INNER JOIN Skladista s ON z.SkladisteID = s.SkladisteID
                ORDER BY z.DatumZaprimanja DESC
            ");

            int y = 0;

            foreach (DataRow row in dt.Rows)
            {
                Panel kartica = new Panel();
                kartica.BackColor = Color.FromArgb(250, 248, 243);
                kartica.BorderStyle = BorderStyle.FixedSingle;
                kartica.Location = new Point(0, y);
                kartica.Size = new Size(pnlPovijestZaprimanja.Width - 20, 58);

                Label naslov = new Label();
                naslov.Text = row["Broj"] + " · " + row["Skladiste"];
                naslov.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                naslov.Location = new Point(12, 8);
                naslov.Size = new Size(kartica.Width - 24, 20);

                Label opis = new Label();
                opis.Text =
                    Convert.ToDateTime(row["DatumZaprimanja"]).ToString("dd.MM.yyyy. HH:mm") +
                    " · " + Convert.ToDecimal(row["Kolicina"]).ToString("N0") +
                    " stavki · " + row["Zaprimio"];

                opis.Font = new Font("Segoe UI", 8);
                opis.ForeColor = Color.FromArgb(90, 100, 98);
                opis.Location = new Point(12, 31);
                opis.Size = new Size(kartica.Width - 24, 18);

                kartica.Controls.Add(naslov);
                kartica.Controls.Add(opis);

                pnlPovijestZaprimanja.Controls.Add(kartica);

                y += 70;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}