namespace MarijaERP
{
    partial class ZaprimanjeControl
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
            pnlUlaz = new Panel();
            btnZaprimiRobu = new Button();
            txtZaprimio = new TextBox();
            label11 = new Label();
            txtNabavnaCijena = new TextBox();
            txtKolicinaZaprimanja = new TextBox();
            label10 = new Label();
            label9 = new Label();
            dtpRokTrajanja = new DateTimePicker();
            label8 = new Label();
            txtLotDobavljaca = new TextBox();
            label7 = new Label();
            txtOtpremnica = new TextBox();
            label6 = new Label();
            cmbSkladiste = new ComboBox();
            label5 = new Label();
            cmbStavka = new ComboBox();
            label4 = new Label();
            cmbNarudzbenica = new ComboBox();
            lblTekst = new Label();
            label3 = new Label();
            label1 = new Label();
            pnlPovijestZaprimanja = new Panel();
            panel1 = new Panel();
            label12 = new Label();
            label13 = new Label();
            pnlUlaz.SuspendLayout();
            panel1.SuspendLayout();
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
            label2.TabIndex = 11;
            label2.Text = "OPERATIVNI CENTAR";
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNaslov.Location = new Point(280, 42);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(230, 37);
            lblNaslov.TabIndex = 12;
            lblNaslov.Text = "Zaprimanje robe";
            // 
            // pnlUlaz
            // 
            pnlUlaz.BackColor = Color.White;
            pnlUlaz.BorderStyle = BorderStyle.FixedSingle;
            pnlUlaz.Controls.Add(btnZaprimiRobu);
            pnlUlaz.Controls.Add(txtZaprimio);
            pnlUlaz.Controls.Add(label11);
            pnlUlaz.Controls.Add(txtNabavnaCijena);
            pnlUlaz.Controls.Add(txtKolicinaZaprimanja);
            pnlUlaz.Controls.Add(label10);
            pnlUlaz.Controls.Add(label9);
            pnlUlaz.Controls.Add(dtpRokTrajanja);
            pnlUlaz.Controls.Add(label8);
            pnlUlaz.Controls.Add(txtLotDobavljaca);
            pnlUlaz.Controls.Add(label7);
            pnlUlaz.Controls.Add(txtOtpremnica);
            pnlUlaz.Controls.Add(label6);
            pnlUlaz.Controls.Add(cmbSkladiste);
            pnlUlaz.Controls.Add(label5);
            pnlUlaz.Controls.Add(cmbStavka);
            pnlUlaz.Controls.Add(label4);
            pnlUlaz.Controls.Add(cmbNarudzbenica);
            pnlUlaz.Controls.Add(lblTekst);
            pnlUlaz.Controls.Add(label3);
            pnlUlaz.Controls.Add(label1);
            pnlUlaz.Location = new Point(280, 93);
            pnlUlaz.Name = "pnlUlaz";
            pnlUlaz.Size = new Size(356, 588);
            pnlUlaz.TabIndex = 13;
            // 
            // btnZaprimiRobu
            // 
            btnZaprimiRobu.BackColor = Color.FromArgb(0, 128, 112);
            btnZaprimiRobu.FlatStyle = FlatStyle.Flat;
            btnZaprimiRobu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnZaprimiRobu.ForeColor = Color.White;
            btnZaprimiRobu.Location = new Point(15, 532);
            btnZaprimiRobu.Name = "btnZaprimiRobu";
            btnZaprimiRobu.Size = new Size(324, 38);
            btnZaprimiRobu.TabIndex = 32;
            btnZaprimiRobu.Text = "⇓ Zaprimi robu";
            btnZaprimiRobu.UseVisualStyleBackColor = false;
            btnZaprimiRobu.Click += btnZaprimiRobu_Click;
            // 
            // txtZaprimio
            // 
            txtZaprimio.Location = new Point(15, 491);
            txtZaprimio.Name = "txtZaprimio";
            txtZaprimio.Size = new Size(324, 23);
            txtZaprimio.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(15, 473);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 30;
            label11.Text = "Zaprimio";
            // 
            // txtNabavnaCijena
            // 
            txtNabavnaCijena.Location = new Point(181, 438);
            txtNabavnaCijena.Name = "txtNabavnaCijena";
            txtNabavnaCijena.Size = new Size(158, 23);
            txtNabavnaCijena.TabIndex = 29;
            // 
            // txtKolicinaZaprimanja
            // 
            txtKolicinaZaprimanja.Location = new Point(15, 438);
            txtKolicinaZaprimanja.Name = "txtKolicinaZaprimanja";
            txtKolicinaZaprimanja.Size = new Size(158, 23);
            txtKolicinaZaprimanja.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(181, 420);
            label10.Name = "label10";
            label10.Size = new Size(90, 15);
            label10.TabIndex = 27;
            label10.Text = "Nabavna cijena";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(15, 420);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 26;
            label9.Text = "Količina";
            // 
            // dtpRokTrajanja
            // 
            dtpRokTrajanja.Location = new Point(15, 380);
            dtpRokTrajanja.Name = "dtpRokTrajanja";
            dtpRokTrajanja.Size = new Size(324, 23);
            dtpRokTrajanja.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(15, 362);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 24;
            label8.Text = "Rok trajanja";
            // 
            // txtLotDobavljaca
            // 
            txtLotDobavljaca.Location = new Point(15, 320);
            txtLotDobavljaca.Name = "txtLotDobavljaca";
            txtLotDobavljaca.Size = new Size(324, 23);
            txtLotDobavljaca.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(15, 302);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 22;
            label7.Text = "LOT dobavljača";
            // 
            // txtOtpremnica
            // 
            txtOtpremnica.Location = new Point(15, 262);
            txtOtpremnica.Name = "txtOtpremnica";
            txtOtpremnica.Size = new Size(324, 23);
            txtOtpremnica.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(15, 244);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 20;
            label6.Text = "Otpremnica";
            // 
            // cmbSkladiste
            // 
            cmbSkladiste.FormattingEnabled = true;
            cmbSkladiste.Location = new Point(15, 205);
            cmbSkladiste.Name = "cmbSkladiste";
            cmbSkladiste.Size = new Size(324, 23);
            cmbSkladiste.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(15, 187);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 18;
            label5.Text = "Skladište";
            // 
            // cmbStavka
            // 
            cmbStavka.FormattingEnabled = true;
            cmbStavka.Location = new Point(15, 149);
            cmbStavka.Name = "cmbStavka";
            cmbStavka.Size = new Size(324, 23);
            cmbStavka.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(15, 131);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 16;
            label4.Text = "Stavka";
            // 
            // cmbNarudzbenica
            // 
            cmbNarudzbenica.FormattingEnabled = true;
            cmbNarudzbenica.Location = new Point(15, 94);
            cmbNarudzbenica.Name = "cmbNarudzbenica";
            cmbNarudzbenica.Size = new Size(324, 23);
            cmbNarudzbenica.TabIndex = 15;
            // 
            // lblTekst
            // 
            lblTekst.AutoSize = true;
            lblTekst.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTekst.ForeColor = SystemColors.ControlDarkDark;
            lblTekst.Location = new Point(15, 76);
            lblTekst.Name = "lblTekst";
            lblTekst.Size = new Size(83, 15);
            lblTekst.TabIndex = 14;
            lblTekst.Text = "Narudžbenica";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.Location = new Point(15, 31);
            label3.Name = "label3";
            label3.Size = new Size(191, 25);
            label3.TabIndex = 12;
            label3.Text = "Zaprimanje po LOT-u";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 11;
            label1.Text = "ULAZ ROBE";
            // 
            // pnlPovijestZaprimanja
            // 
            pnlPovijestZaprimanja.BackColor = Color.White;
            pnlPovijestZaprimanja.Location = new Point(30, 85);
            pnlPovijestZaprimanja.Name = "pnlPovijestZaprimanja";
            pnlPovijestZaprimanja.Size = new Size(988, 475);
            pnlPovijestZaprimanja.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label13);
            panel1.Controls.Add(pnlPovijestZaprimanja);
            panel1.Controls.Add(label12);
            panel1.Location = new Point(667, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 588);
            panel1.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(20, 16);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 12;
            label12.Text = "POVIJEST";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label13.Location = new Point(20, 31);
            label13.Name = "label13";
            label13.Size = new Size(169, 25);
            label13.TabIndex = 15;
            label13.Text = "Zadnja zaprimanja";
            // 
            // ZaprimanjeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 232);
            Controls.Add(pnlUlaz);
            Controls.Add(lblNaslov);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ZaprimanjeControl";
            Size = new Size(2071, 940);
            pnlUlaz.ResumeLayout(false);
            pnlUlaz.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lblNaslov;
        private Panel pnlUlaz;
        private Label label1;
        private Label label3;
        private Label lblTekst;
        private Label label6;
        private ComboBox cmbSkladiste;
        private Label label5;
        private ComboBox cmbStavka;
        private Label label4;
        private ComboBox cmbNarudzbenica;
        private TextBox txtLotDobavljaca;
        private Label label7;
        private TextBox txtOtpremnica;
        private DateTimePicker dtpRokTrajanja;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label11;
        private TextBox txtNabavnaCijena;
        private TextBox txtKolicinaZaprimanja;
        private TextBox txtZaprimio;
        private Button btnZaprimiRobu;
        private Panel pnlPovijestZaprimanja;
        private Panel panel1;
        private Label label12;
        private Label label13;
    }
}
