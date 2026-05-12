namespace MarijaERP
{
    partial class NarudzbeControl
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
            label2 = new Label();
            lblNaslov = new Label();
            pnlNovaNarudzba = new Panel();
            btnKreirajNarudzbu = new Button();
            txtCijena = new TextBox();
            label7 = new Label();
            txtKolicina = new TextBox();
            label6 = new Label();
            cmbArtikl = new ComboBox();
            label5 = new Label();
            dtpOcekivaniDatum = new DateTimePicker();
            label4 = new Label();
            lblTekstDobavljac = new Label();
            cmbDobavljac = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            pnlOtvoreneNarudzbe = new Panel();
            dgvNarudzbe = new DataGridView();
            label9 = new Label();
            label8 = new Label();
            pnlNovaNarudzba.SuspendLayout();
            pnlOtvoreneNarudzbe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNarudzbe).BeginInit();
            SuspendLayout();
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
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNaslov.Location = new Point(280, 42);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(194, 37);
            lblNaslov.TabIndex = 11;
            lblNaslov.Text = "Narudžbenice";
            // 
            // pnlNovaNarudzba
            // 
            pnlNovaNarudzba.BackColor = Color.White;
            pnlNovaNarudzba.BorderStyle = BorderStyle.FixedSingle;
            pnlNovaNarudzba.Controls.Add(btnKreirajNarudzbu);
            pnlNovaNarudzba.Controls.Add(txtCijena);
            pnlNovaNarudzba.Controls.Add(label7);
            pnlNovaNarudzba.Controls.Add(txtKolicina);
            pnlNovaNarudzba.Controls.Add(label6);
            pnlNovaNarudzba.Controls.Add(cmbArtikl);
            pnlNovaNarudzba.Controls.Add(label5);
            pnlNovaNarudzba.Controls.Add(dtpOcekivaniDatum);
            pnlNovaNarudzba.Controls.Add(label4);
            pnlNovaNarudzba.Controls.Add(lblTekstDobavljac);
            pnlNovaNarudzba.Controls.Add(cmbDobavljac);
            pnlNovaNarudzba.Controls.Add(label3);
            pnlNovaNarudzba.Controls.Add(label1);
            pnlNovaNarudzba.Location = new Point(280, 105);
            pnlNovaNarudzba.Name = "pnlNovaNarudzba";
            pnlNovaNarudzba.Size = new Size(370, 373);
            pnlNovaNarudzba.TabIndex = 12;
            // 
            // btnKreirajNarudzbu
            // 
            btnKreirajNarudzbu.BackColor = Color.FromArgb(0, 128, 112);
            btnKreirajNarudzbu.FlatStyle = FlatStyle.Flat;
            btnKreirajNarudzbu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnKreirajNarudzbu.ForeColor = Color.White;
            btnKreirajNarudzbu.Location = new Point(16, 306);
            btnKreirajNarudzbu.Name = "btnKreirajNarudzbu";
            btnKreirajNarudzbu.Size = new Size(336, 38);
            btnKreirajNarudzbu.TabIndex = 22;
            btnKreirajNarudzbu.Text = "+ Kreiraj narudžbu";
            btnKreirajNarudzbu.UseVisualStyleBackColor = false;
            btnKreirajNarudzbu.Click += btnKreirajNarudzbu_Click;
            // 
            // txtCijena
            // 
            txtCijena.Location = new Point(187, 256);
            txtCijena.Name = "txtCijena";
            txtCijena.Size = new Size(165, 23);
            txtCijena.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(187, 238);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 20;
            label7.Text = "Cijena";
            // 
            // txtKolicina
            // 
            txtKolicina.Location = new Point(16, 256);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(165, 23);
            txtKolicina.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(16, 238);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 18;
            label6.Text = "Količina";
            // 
            // cmbArtikl
            // 
            cmbArtikl.FormattingEnabled = true;
            cmbArtikl.Location = new Point(16, 199);
            cmbArtikl.Name = "cmbArtikl";
            cmbArtikl.Size = new Size(336, 23);
            cmbArtikl.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(16, 181);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 16;
            label5.Text = "Artikl";
            // 
            // dtpOcekivaniDatum
            // 
            dtpOcekivaniDatum.Location = new Point(16, 142);
            dtpOcekivaniDatum.Name = "dtpOcekivaniDatum";
            dtpOcekivaniDatum.Size = new Size(336, 23);
            dtpOcekivaniDatum.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(16, 124);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 14;
            label4.Text = "Očekivani datum";
            // 
            // lblTekstDobavljac
            // 
            lblTekstDobavljac.AutoSize = true;
            lblTekstDobavljac.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTekstDobavljac.ForeColor = SystemColors.ControlDarkDark;
            lblTekstDobavljac.Location = new Point(16, 70);
            lblTekstDobavljac.Name = "lblTekstDobavljac";
            lblTekstDobavljac.Size = new Size(61, 15);
            lblTekstDobavljac.TabIndex = 13;
            lblTekstDobavljac.Text = "Dobavljač";
            // 
            // cmbDobavljac
            // 
            cmbDobavljac.FormattingEnabled = true;
            cmbDobavljac.Location = new Point(16, 88);
            cmbDobavljac.Name = "cmbDobavljac";
            cmbDobavljac.Size = new Size(336, 23);
            cmbDobavljac.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.Location = new Point(16, 29);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 11;
            label3.Text = "Narudžbenica";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 10;
            label1.Text = "NOVA NABAVA";
            // 
            // pnlOtvoreneNarudzbe
            // 
            pnlOtvoreneNarudzbe.BackColor = Color.White;
            pnlOtvoreneNarudzbe.BorderStyle = BorderStyle.FixedSingle;
            pnlOtvoreneNarudzbe.Controls.Add(dgvNarudzbe);
            pnlOtvoreneNarudzbe.Controls.Add(label9);
            pnlOtvoreneNarudzbe.Controls.Add(label8);
            pnlOtvoreneNarudzbe.Location = new Point(675, 105);
            pnlOtvoreneNarudzbe.Name = "pnlOtvoreneNarudzbe";
            pnlOtvoreneNarudzbe.Size = new Size(1016, 373);
            pnlOtvoreneNarudzbe.TabIndex = 13;
            // 
            // dgvNarudzbe
            // 
            dgvNarudzbe.AllowUserToAddRows = false;
            dgvNarudzbe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNarudzbe.BackgroundColor = Color.White;
            dgvNarudzbe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNarudzbe.Location = new Point(27, 70);
            dgvNarudzbe.Name = "dgvNarudzbe";
            dgvNarudzbe.ReadOnly = true;
            dgvNarudzbe.RowHeadersVisible = false;
            dgvNarudzbe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNarudzbe.Size = new Size(966, 274);
            dgvNarudzbe.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label9.Location = new Point(17, 29);
            label9.Name = "label9";
            label9.Size = new Size(212, 25);
            label9.TabIndex = 12;
            label9.Text = "Otvorene narudžbenice";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(17, 14);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 11;
            label8.Text = "NABAVNI TOK";
            // 
            // NarudzbeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 232);
            Controls.Add(pnlOtvoreneNarudzbe);
            Controls.Add(pnlNovaNarudzba);
            Controls.Add(lblNaslov);
            Controls.Add(label2);
            Name = "NarudzbeControl";
            Size = new Size(1775, 760);
            pnlNovaNarudzba.ResumeLayout(false);
            pnlNovaNarudzba.PerformLayout();
            pnlOtvoreneNarudzbe.ResumeLayout(false);
            pnlOtvoreneNarudzbe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNarudzbe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lblNaslov;
        private Panel pnlNovaNarudzba;
        private Label label1;
        private ComboBox cmbDobavljac;
        private Label label3;
        private Label lblTekstDobavljac;
        private ComboBox cmbArtikl;
        private Label label5;
        private DateTimePicker dtpOcekivaniDatum;
        private Label label4;
        private Label label7;
        private TextBox txtKolicina;
        private Label label6;
        private Button btnKreirajNarudzbu;
        private TextBox txtCijena;
        private Panel pnlOtvoreneNarudzbe;
        private Label label9;
        private Label label8;
        private DataGridView dgvNarudzbe;
    }
}
