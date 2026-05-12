namespace MarijaERP
{
    partial class LotTragControl
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
            btnPrikaziTrag = new Button();
            cmbLot = new ComboBox();
            lblTekst = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label13 = new Label();
            pnlKretanjeLota = new Panel();
            label12 = new Label();
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
            label2.TabIndex = 13;
            label2.Text = "OPERATIVNI CENTAR";
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNaslov.Location = new Point(280, 42);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(195, 37);
            lblNaslov.TabIndex = 14;
            lblNaslov.Text = "LOT sljedivost";
            // 
            // pnlUlaz
            // 
            pnlUlaz.BackColor = Color.White;
            pnlUlaz.BorderStyle = BorderStyle.FixedSingle;
            pnlUlaz.Controls.Add(btnPrikaziTrag);
            pnlUlaz.Controls.Add(cmbLot);
            pnlUlaz.Controls.Add(lblTekst);
            pnlUlaz.Controls.Add(label3);
            pnlUlaz.Controls.Add(label1);
            pnlUlaz.Location = new Point(280, 96);
            pnlUlaz.Name = "pnlUlaz";
            pnlUlaz.Size = new Size(356, 216);
            pnlUlaz.TabIndex = 15;
            // 
            // btnPrikaziTrag
            // 
            btnPrikaziTrag.BackColor = Color.FromArgb(0, 128, 112);
            btnPrikaziTrag.FlatStyle = FlatStyle.Flat;
            btnPrikaziTrag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnPrikaziTrag.ForeColor = Color.White;
            btnPrikaziTrag.Location = new Point(15, 144);
            btnPrikaziTrag.Name = "btnPrikaziTrag";
            btnPrikaziTrag.Size = new Size(324, 38);
            btnPrikaziTrag.TabIndex = 32;
            btnPrikaziTrag.Text = "Prikaži trag";
            btnPrikaziTrag.UseVisualStyleBackColor = false;
            btnPrikaziTrag.Click += btnPrikaziTrag_Click;
            // 
            // cmbLot
            // 
            cmbLot.FormattingEnabled = true;
            cmbLot.Location = new Point(15, 94);
            cmbLot.Name = "cmbLot";
            cmbLot.Size = new Size(324, 23);
            cmbLot.TabIndex = 15;
            // 
            // lblTekst
            // 
            lblTekst.AutoSize = true;
            lblTekst.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTekst.ForeColor = SystemColors.ControlDarkDark;
            lblTekst.Location = new Point(15, 76);
            lblTekst.Name = "lblTekst";
            lblTekst.Size = new Size(29, 15);
            lblTekst.TabIndex = 14;
            lblTekst.Text = "LOT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.Location = new Point(15, 31);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 12;
            label3.Text = "Pronađi LOT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 11;
            label1.Text = "SLJEDIVOST";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label13);
            panel1.Controls.Add(pnlKretanjeLota);
            panel1.Controls.Add(label12);
            panel1.Location = new Point(660, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 415);
            panel1.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label13.Location = new Point(20, 31);
            label13.Name = "label13";
            label13.Size = new Size(139, 25);
            label13.TabIndex = 15;
            label13.Text = "Kretanje LOT-a";
            // 
            // pnlKretanjeLota
            // 
            pnlKretanjeLota.BackColor = Color.White;
            pnlKretanjeLota.Location = new Point(30, 85);
            pnlKretanjeLota.Name = "pnlKretanjeLota";
            pnlKretanjeLota.Size = new Size(988, 296);
            pnlKretanjeLota.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(20, 16);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 12;
            label12.Text = "AUDIT";
            // 
            // LotTragControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 232);
            Controls.Add(panel1);
            Controls.Add(pnlUlaz);
            Controls.Add(lblNaslov);
            Controls.Add(label2);
            Name = "LotTragControl";
            Size = new Size(1622, 971);
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
        private Button btnPrikaziTrag;
        private ComboBox cmbLot;
        private Label lblTekst;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label label13;
        private Panel pnlKretanjeLota;
        private Label label12;
    }
}
