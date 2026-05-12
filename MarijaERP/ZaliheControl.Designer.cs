namespace MarijaERP
{
    partial class ZaliheControl
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
            btnIzdajFifo = new Button();
            txtIzdao = new TextBox();
            label11 = new Label();
            txtKolicinaIzdavanja = new TextBox();
            label9 = new Label();
            txtRazlog = new TextBox();
            label6 = new Label();
            label5 = new Label();
            cmbSkladisteFifo = new ComboBox();
            cmbArtiklFifo = new ComboBox();
            lblTekst = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label13 = new Label();
            label12 = new Label();
            dgvLotovi = new DataGridView();
            pnlUlaz.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLotovi).BeginInit();
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
            label2.TabIndex = 12;
            label2.Text = "OPERATIVNI CENTAR";
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNaslov.Location = new Point(280, 42);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(303, 37);
            lblNaslov.TabIndex = 13;
            lblNaslov.Text = "Zalihe i FIFO izdavanje";
            // 
            // pnlUlaz
            // 
            pnlUlaz.BackColor = Color.White;
            pnlUlaz.BorderStyle = BorderStyle.FixedSingle;
            pnlUlaz.Controls.Add(btnIzdajFifo);
            pnlUlaz.Controls.Add(txtIzdao);
            pnlUlaz.Controls.Add(label11);
            pnlUlaz.Controls.Add(txtKolicinaIzdavanja);
            pnlUlaz.Controls.Add(label9);
            pnlUlaz.Controls.Add(txtRazlog);
            pnlUlaz.Controls.Add(label6);
            pnlUlaz.Controls.Add(label5);
            pnlUlaz.Controls.Add(cmbSkladisteFifo);
            pnlUlaz.Controls.Add(cmbArtiklFifo);
            pnlUlaz.Controls.Add(lblTekst);
            pnlUlaz.Controls.Add(label3);
            pnlUlaz.Controls.Add(label1);
            pnlUlaz.Location = new Point(280, 94);
            pnlUlaz.Name = "pnlUlaz";
            pnlUlaz.Size = new Size(356, 439);
            pnlUlaz.TabIndex = 14;
            // 
            // btnIzdajFifo
            // 
            btnIzdajFifo.BackColor = Color.DarkRed;
            btnIzdajFifo.FlatStyle = FlatStyle.Flat;
            btnIzdajFifo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnIzdajFifo.ForeColor = Color.White;
            btnIzdajFifo.Location = new Point(15, 371);
            btnIzdajFifo.Name = "btnIzdajFifo";
            btnIzdajFifo.Size = new Size(324, 38);
            btnIzdajFifo.TabIndex = 32;
            btnIzdajFifo.Text = "⇒ Izdaj FIFO";
            btnIzdajFifo.UseVisualStyleBackColor = false;
            btnIzdajFifo.Click += btnIzdajFifo_Click;
            // 
            // txtIzdao
            // 
            txtIzdao.Location = new Point(15, 322);
            txtIzdao.Name = "txtIzdao";
            txtIzdao.Size = new Size(324, 23);
            txtIzdao.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(15, 304);
            label11.Name = "label11";
            label11.Size = new Size(37, 15);
            label11.TabIndex = 30;
            label11.Text = "Izdao";
            // 
            // txtKolicinaIzdavanja
            // 
            txtKolicinaIzdavanja.Location = new Point(15, 205);
            txtKolicinaIzdavanja.Name = "txtKolicinaIzdavanja";
            txtKolicinaIzdavanja.Size = new Size(324, 23);
            txtKolicinaIzdavanja.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(15, 187);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 26;
            label9.Text = "Količina";
            // 
            // txtRazlog
            // 
            txtRazlog.Location = new Point(15, 262);
            txtRazlog.Name = "txtRazlog";
            txtRazlog.Size = new Size(324, 23);
            txtRazlog.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(15, 244);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 20;
            label6.Text = "Razlog";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(15, 131);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 18;
            label5.Text = "Skladište";
            // 
            // cmbSkladisteFifo
            // 
            cmbSkladisteFifo.FormattingEnabled = true;
            cmbSkladisteFifo.Location = new Point(15, 149);
            cmbSkladisteFifo.Name = "cmbSkladisteFifo";
            cmbSkladisteFifo.Size = new Size(324, 23);
            cmbSkladisteFifo.TabIndex = 17;
            // 
            // cmbArtiklFifo
            // 
            cmbArtiklFifo.FormattingEnabled = true;
            cmbArtiklFifo.Location = new Point(15, 94);
            cmbArtiklFifo.Name = "cmbArtiklFifo";
            cmbArtiklFifo.Size = new Size(324, 23);
            cmbArtiklFifo.TabIndex = 15;
            // 
            // lblTekst
            // 
            lblTekst.AutoSize = true;
            lblTekst.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTekst.ForeColor = SystemColors.ControlDarkDark;
            lblTekst.Location = new Point(15, 76);
            lblTekst.Name = "lblTekst";
            lblTekst.Size = new Size(38, 15);
            lblTekst.TabIndex = 14;
            lblTekst.Text = "Artikl";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.Location = new Point(15, 31);
            label3.Name = "label3";
            label3.Size = new Size(136, 25);
            label3.TabIndex = 12;
            label3.Text = "FIFO izdavanje";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 11;
            label1.Text = "IZLAZ ROBE";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvLotovi);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Location = new Point(659, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 439);
            panel1.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label13.Location = new Point(20, 31);
            label13.Name = "label13";
            label13.Size = new Size(148, 25);
            label13.TabIndex = 15;
            label13.Text = "Stanje po LOT-u";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(20, 16);
            label12.Name = "label12";
            label12.Size = new Size(77, 15);
            label12.TabIndex = 12;
            label12.Text = "LOT SLOJEVI";
            // 
            // dgvLotovi
            // 
            dgvLotovi.BackgroundColor = Color.White;
            dgvLotovi.BorderStyle = BorderStyle.None;
            dgvLotovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLotovi.Location = new Point(31, 76);
            dgvLotovi.Name = "dgvLotovi";
            dgvLotovi.Size = new Size(984, 333);
            dgvLotovi.TabIndex = 16;
            // 
            // ZaliheControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 232);
            Controls.Add(panel1);
            Controls.Add(pnlUlaz);
            Controls.Add(lblNaslov);
            Controls.Add(label2);
            Name = "ZaliheControl";
            Size = new Size(1871, 971);
            pnlUlaz.ResumeLayout(false);
            pnlUlaz.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLotovi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lblNaslov;
        private Panel pnlUlaz;
        private Button btnIzdajFifo;
        private TextBox txtIzdao;
        private Label label11;
        private TextBox txtKolicinaIzdavanja;
        private Label label9;
        private TextBox txtRazlog;
        private Label label6;
        private Label label5;
        private ComboBox cmbSkladisteFifo;
        private ComboBox cmbArtiklFifo;
        private Label lblTekst;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label label13;
        private Label label12;
        private DataGridView dgvLotovi;
    }
}
