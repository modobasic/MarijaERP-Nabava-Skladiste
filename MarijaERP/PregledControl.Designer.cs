namespace MarijaERP
{
    partial class PregledControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNaslov = new Label();
            dgvPregled = new DataGridView();
            pnlVrijednostZalihe = new Panel();
            lblBrojLotova = new Label();
            lblVrijednostZalihe = new Label();
            lblTekstVrijednost = new Label();
            pnlUkupnaKolicina = new Panel();
            lblSvaSkladista = new Label();
            lblUkupnaKolicina = new Label();
            lblTekstKolicina = new Label();
            pnlNiskaZaliha = new Panel();
            lblIspodPraga = new Label();
            lblNiskaZaliha = new Label();
            lblTekstZaliha = new Label();
            pnlOtvorenaNabava = new Panel();
            lblOtvorenihStavki = new Label();
            lblOtvorenaNabava = new Label();
            lblTekstOtvorenaNabava = new Label();
            pnlUpozorenja = new Panel();
            pnlListaUpozorenja = new Panel();
            lblNiskaZalihatxt = new Label();
            lblUpozorenja = new Label();
            pnlPregled = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPregled).BeginInit();
            pnlVrijednostZalihe.SuspendLayout();
            pnlUkupnaKolicina.SuspendLayout();
            pnlNiskaZaliha.SuspendLayout();
            pnlOtvorenaNabava.SuspendLayout();
            pnlUpozorenja.SuspendLayout();
            pnlPregled.SuspendLayout();
            SuspendLayout();
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNaslov.Location = new Point(280, 42);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(352, 37);
            lblNaslov.TabIndex = 0;
            lblNaslov.Text = "Pregled nabave i skladišta";
            // 
            // dgvPregled
            // 
            dgvPregled.AllowUserToAddRows = false;
            dgvPregled.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPregled.BackgroundColor = Color.White;
            dgvPregled.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPregled.GridColor = Color.Black;
            dgvPregled.Location = new Point(28, 24);
            dgvPregled.Name = "dgvPregled";
            dgvPregled.ReadOnly = true;
            dgvPregled.Size = new Size(942, 174);
            dgvPregled.TabIndex = 1;
            // 
            // pnlVrijednostZalihe
            // 
            pnlVrijednostZalihe.BackColor = Color.White;
            pnlVrijednostZalihe.BorderStyle = BorderStyle.FixedSingle;
            pnlVrijednostZalihe.Controls.Add(lblBrojLotova);
            pnlVrijednostZalihe.Controls.Add(lblVrijednostZalihe);
            pnlVrijednostZalihe.Controls.Add(lblTekstVrijednost);
            pnlVrijednostZalihe.Location = new Point(280, 93);
            pnlVrijednostZalihe.Name = "pnlVrijednostZalihe";
            pnlVrijednostZalihe.Size = new Size(330, 106);
            pnlVrijednostZalihe.TabIndex = 2;
            // 
            // lblBrojLotova
            // 
            lblBrojLotova.AutoSize = true;
            lblBrojLotova.Location = new Point(13, 70);
            lblBrojLotova.Name = "lblBrojLotova";
            lblBrojLotova.Size = new Size(120, 15);
            lblBrojLotova.TabIndex = 1;
            lblBrojLotova.Text = "0 aktivnih LOT slojeva";
            // 
            // lblVrijednostZalihe
            // 
            lblVrijednostZalihe.AutoSize = true;
            lblVrijednostZalihe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblVrijednostZalihe.Location = new Point(13, 32);
            lblVrijednostZalihe.Name = "lblVrijednostZalihe";
            lblVrijednostZalihe.Size = new Size(84, 32);
            lblVrijednostZalihe.TabIndex = 0;
            lblVrijednostZalihe.Text = "0,00 €";
            // 
            // lblTekstVrijednost
            // 
            lblTekstVrijednost.AutoSize = true;
            lblTekstVrijednost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTekstVrijednost.ForeColor = SystemColors.ControlDarkDark;
            lblTekstVrijednost.Location = new Point(13, 15);
            lblTekstVrijednost.Name = "lblTekstVrijednost";
            lblTekstVrijednost.Size = new Size(99, 15);
            lblTekstVrijednost.TabIndex = 0;
            lblTekstVrijednost.Text = "Vrijednost zalihe";
            // 
            // pnlUkupnaKolicina
            // 
            pnlUkupnaKolicina.BackColor = Color.White;
            pnlUkupnaKolicina.BorderStyle = BorderStyle.FixedSingle;
            pnlUkupnaKolicina.Controls.Add(lblSvaSkladista);
            pnlUkupnaKolicina.Controls.Add(lblUkupnaKolicina);
            pnlUkupnaKolicina.Controls.Add(lblTekstKolicina);
            pnlUkupnaKolicina.Location = new Point(630, 93);
            pnlUkupnaKolicina.Name = "pnlUkupnaKolicina";
            pnlUkupnaKolicina.Size = new Size(330, 106);
            pnlUkupnaKolicina.TabIndex = 3;
            // 
            // lblSvaSkladista
            // 
            lblSvaSkladista.AutoSize = true;
            lblSvaSkladista.Location = new Point(13, 70);
            lblSvaSkladista.Name = "lblSvaSkladista";
            lblSvaSkladista.Size = new Size(72, 15);
            lblSvaSkladista.TabIndex = 3;
            lblSvaSkladista.Text = "sva skladišta";
            // 
            // lblUkupnaKolicina
            // 
            lblUkupnaKolicina.AutoSize = true;
            lblUkupnaKolicina.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblUkupnaKolicina.Location = new Point(13, 32);
            lblUkupnaKolicina.Name = "lblUkupnaKolicina";
            lblUkupnaKolicina.Size = new Size(28, 32);
            lblUkupnaKolicina.TabIndex = 2;
            lblUkupnaKolicina.Text = "0";
            // 
            // lblTekstKolicina
            // 
            lblTekstKolicina.AutoSize = true;
            lblTekstKolicina.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTekstKolicina.ForeColor = SystemColors.ControlDarkDark;
            lblTekstKolicina.Location = new Point(13, 15);
            lblTekstKolicina.Name = "lblTekstKolicina";
            lblTekstKolicina.Size = new Size(95, 15);
            lblTekstKolicina.TabIndex = 1;
            lblTekstKolicina.Text = "Ukupna količina";
            // 
            // pnlNiskaZaliha
            // 
            pnlNiskaZaliha.BackColor = Color.White;
            pnlNiskaZaliha.BorderStyle = BorderStyle.FixedSingle;
            pnlNiskaZaliha.Controls.Add(lblIspodPraga);
            pnlNiskaZaliha.Controls.Add(lblNiskaZaliha);
            pnlNiskaZaliha.Controls.Add(lblTekstZaliha);
            pnlNiskaZaliha.Location = new Point(980, 93);
            pnlNiskaZaliha.Name = "pnlNiskaZaliha";
            pnlNiskaZaliha.Size = new Size(330, 106);
            pnlNiskaZaliha.TabIndex = 4;
            // 
            // lblIspodPraga
            // 
            lblIspodPraga.AutoSize = true;
            lblIspodPraga.Location = new Point(17, 70);
            lblIspodPraga.Name = "lblIspodPraga";
            lblIspodPraga.Size = new Size(101, 15);
            lblIspodPraga.TabIndex = 3;
            lblIspodPraga.Text = "artikli ispod praga";
            // 
            // lblNiskaZaliha
            // 
            lblNiskaZaliha.AutoSize = true;
            lblNiskaZaliha.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNiskaZaliha.Location = new Point(17, 32);
            lblNiskaZaliha.Name = "lblNiskaZaliha";
            lblNiskaZaliha.Size = new Size(28, 32);
            lblNiskaZaliha.TabIndex = 2;
            lblNiskaZaliha.Text = "0";
            // 
            // lblTekstZaliha
            // 
            lblTekstZaliha.AutoSize = true;
            lblTekstZaliha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTekstZaliha.ForeColor = SystemColors.ControlDarkDark;
            lblTekstZaliha.Location = new Point(17, 15);
            lblTekstZaliha.Name = "lblTekstZaliha";
            lblTekstZaliha.Size = new Size(71, 15);
            lblTekstZaliha.TabIndex = 1;
            lblTekstZaliha.Text = "Niska zaliha";
            // 
            // pnlOtvorenaNabava
            // 
            pnlOtvorenaNabava.BackColor = Color.White;
            pnlOtvorenaNabava.BorderStyle = BorderStyle.FixedSingle;
            pnlOtvorenaNabava.Controls.Add(lblOtvorenihStavki);
            pnlOtvorenaNabava.Controls.Add(lblOtvorenaNabava);
            pnlOtvorenaNabava.Controls.Add(lblTekstOtvorenaNabava);
            pnlOtvorenaNabava.Location = new Point(1330, 93);
            pnlOtvorenaNabava.Name = "pnlOtvorenaNabava";
            pnlOtvorenaNabava.Size = new Size(330, 106);
            pnlOtvorenaNabava.TabIndex = 5;
            // 
            // lblOtvorenihStavki
            // 
            lblOtvorenihStavki.AutoSize = true;
            lblOtvorenihStavki.Location = new Point(19, 70);
            lblOtvorenihStavki.Name = "lblOtvorenihStavki";
            lblOtvorenihStavki.Size = new Size(200, 15);
            lblOtvorenihStavki.TabIndex = 3;
            lblOtvorenihStavki.Text = "otvorenih stavki za medne proizvode";
            // 
            // lblOtvorenaNabava
            // 
            lblOtvorenaNabava.AutoSize = true;
            lblOtvorenaNabava.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblOtvorenaNabava.Location = new Point(19, 32);
            lblOtvorenaNabava.Name = "lblOtvorenaNabava";
            lblOtvorenaNabava.Size = new Size(84, 32);
            lblOtvorenaNabava.TabIndex = 2;
            lblOtvorenaNabava.Text = "0,00 €";
            // 
            // lblTekstOtvorenaNabava
            // 
            lblTekstOtvorenaNabava.AutoSize = true;
            lblTekstOtvorenaNabava.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTekstOtvorenaNabava.ForeColor = SystemColors.ControlDarkDark;
            lblTekstOtvorenaNabava.Location = new Point(19, 15);
            lblTekstOtvorenaNabava.Name = "lblTekstOtvorenaNabava";
            lblTekstOtvorenaNabava.Size = new Size(102, 15);
            lblTekstOtvorenaNabava.TabIndex = 1;
            lblTekstOtvorenaNabava.Text = "Otvorena nabava";
            // 
            // pnlUpozorenja
            // 
            pnlUpozorenja.BackColor = Color.White;
            pnlUpozorenja.BorderStyle = BorderStyle.FixedSingle;
            pnlUpozorenja.Controls.Add(pnlListaUpozorenja);
            pnlUpozorenja.Controls.Add(lblNiskaZalihatxt);
            pnlUpozorenja.Controls.Add(lblUpozorenja);
            pnlUpozorenja.Location = new Point(1306, 214);
            pnlUpozorenja.Name = "pnlUpozorenja";
            pnlUpozorenja.Size = new Size(354, 227);
            pnlUpozorenja.TabIndex = 7;
            // 
            // pnlListaUpozorenja
            // 
            pnlListaUpozorenja.AutoScroll = true;
            pnlListaUpozorenja.Location = new Point(23, 59);
            pnlListaUpozorenja.Name = "pnlListaUpozorenja";
            pnlListaUpozorenja.Size = new Size(309, 139);
            pnlListaUpozorenja.TabIndex = 9;
            // 
            // lblNiskaZalihatxt
            // 
            lblNiskaZalihatxt.AutoSize = true;
            lblNiskaZalihatxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNiskaZalihatxt.Location = new Point(18, 26);
            lblNiskaZalihatxt.Name = "lblNiskaZalihatxt";
            lblNiskaZalihatxt.Size = new Size(103, 21);
            lblNiskaZalihatxt.TabIndex = 8;
            lblNiskaZalihatxt.Text = "Niska zaliha";
            // 
            // lblUpozorenja
            // 
            lblUpozorenja.AutoSize = true;
            lblUpozorenja.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblUpozorenja.ForeColor = Color.Teal;
            lblUpozorenja.Location = new Point(18, 13);
            lblUpozorenja.Name = "lblUpozorenja";
            lblUpozorenja.Size = new Size(80, 13);
            lblUpozorenja.TabIndex = 7;
            lblUpozorenja.Text = "UPOZORENJA";
            // 
            // pnlPregled
            // 
            pnlPregled.BackColor = Color.White;
            pnlPregled.BorderStyle = BorderStyle.FixedSingle;
            pnlPregled.Controls.Add(dgvPregled);
            pnlPregled.Location = new Point(280, 214);
            pnlPregled.Name = "pnlPregled";
            pnlPregled.Size = new Size(1000, 227);
            pnlPregled.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(280, 27);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 10;
            label2.Text = "OPERATIVNI CENTAR";
            label2.Click += label2_Click;
            // 
            // PregledControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 232);
            Controls.Add(label2);
            Controls.Add(pnlOtvorenaNabava);
            Controls.Add(pnlNiskaZaliha);
            Controls.Add(pnlUkupnaKolicina);
            Controls.Add(pnlVrijednostZalihe);
            Controls.Add(lblNaslov);
            Controls.Add(pnlUpozorenja);
            Controls.Add(pnlPregled);
            Name = "PregledControl";
            Size = new Size(1675, 947);
            ((System.ComponentModel.ISupportInitialize)dgvPregled).EndInit();
            pnlVrijednostZalihe.ResumeLayout(false);
            pnlVrijednostZalihe.PerformLayout();
            pnlUkupnaKolicina.ResumeLayout(false);
            pnlUkupnaKolicina.PerformLayout();
            pnlNiskaZaliha.ResumeLayout(false);
            pnlNiskaZaliha.PerformLayout();
            pnlOtvorenaNabava.ResumeLayout(false);
            pnlOtvorenaNabava.PerformLayout();
            pnlUpozorenja.ResumeLayout(false);
            pnlUpozorenja.PerformLayout();
            pnlPregled.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNaslov;
        private DataGridView dgvPregled;
        private Panel pnlVrijednostZalihe;
        private Panel pnlUkupnaKolicina;
        private Panel pnlNiskaZaliha;
        private Panel pnlOtvorenaNabava;
        private Label lblTekstVrijednost;
        private Label lblBrojLotova;
        private Label lblVrijednostZalihe;
        private Label lblSvaSkladista;
        private Label lblUkupnaKolicina;
        private Label lblTekstKolicina;
        private Label lblNiskaZaliha;
        private Label lblTekstZaliha;
        private Label lblIspodPraga;
        private Label lblTekstOtvorenaNabava;
        private Label lblOtvorenihStavki;
        private Label lblOtvorenaNabava;
        private Panel pnlUpozorenja;
        private Label lblUpozorenja;
        private Label lblNiskaZalihatxt;
        private Panel pnlPregled;
        private Panel pnlListaUpozorenja;
        private Label label2;
    }
}
