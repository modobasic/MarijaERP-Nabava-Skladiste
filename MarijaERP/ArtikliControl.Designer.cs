namespace MarijaERP
{
    partial class ArtikliControl
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
            pnlArtikli = new Panel();
            lblA = new Label();
            lblMaticniPodaci = new Label();
            dgvArtikli = new DataGridView();
            pnlDobavljaci = new Panel();
            label1 = new Label();
            labelP = new Label();
            pnlListaDobavljaca = new Panel();
            lblNaslov = new Label();
            label2 = new Label();
            pnlArtikli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArtikli).BeginInit();
            pnlDobavljaci.SuspendLayout();
            SuspendLayout();
            // 
            // pnlArtikli
            // 
            pnlArtikli.BackColor = Color.White;
            pnlArtikli.BorderStyle = BorderStyle.FixedSingle;
            pnlArtikli.Controls.Add(lblA);
            pnlArtikli.Controls.Add(lblMaticniPodaci);
            pnlArtikli.Controls.Add(dgvArtikli);
            pnlArtikli.Location = new Point(280, 98);
            pnlArtikli.Name = "pnlArtikli";
            pnlArtikli.Size = new Size(1140, 294);
            pnlArtikli.TabIndex = 0;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblA.Location = new Point(24, 27);
            lblA.Name = "lblA";
            lblA.Size = new Size(65, 25);
            lblA.TabIndex = 9;
            lblA.Text = "Artikli";
            lblA.Click += lblA_Click;
            // 
            // lblMaticniPodaci
            // 
            lblMaticniPodaci.AutoSize = true;
            lblMaticniPodaci.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblMaticniPodaci.ForeColor = Color.Teal;
            lblMaticniPodaci.Location = new Point(24, 12);
            lblMaticniPodaci.Name = "lblMaticniPodaci";
            lblMaticniPodaci.Size = new Size(103, 15);
            lblMaticniPodaci.TabIndex = 8;
            lblMaticniPodaci.Text = "MATIČNI PODACI";
            // 
            // dgvArtikli
            // 
            dgvArtikli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArtikli.BackgroundColor = Color.White;
            dgvArtikli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtikli.Location = new Point(24, 59);
            dgvArtikli.Name = "dgvArtikli";
            dgvArtikli.ReadOnly = true;
            dgvArtikli.RowHeadersVisible = false;
            dgvArtikli.Size = new Size(1090, 205);
            dgvArtikli.TabIndex = 0;
            // 
            // pnlDobavljaci
            // 
            pnlDobavljaci.BackColor = Color.White;
            pnlDobavljaci.BorderStyle = BorderStyle.FixedSingle;
            pnlDobavljaci.Controls.Add(label1);
            pnlDobavljaci.Controls.Add(labelP);
            pnlDobavljaci.Controls.Add(pnlListaDobavljaca);
            pnlDobavljaci.Location = new Point(280, 408);
            pnlDobavljaci.Name = "pnlDobavljaci";
            pnlDobavljaci.Size = new Size(600, 297);
            pnlDobavljaci.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 10;
            label1.Text = "Dobavljači";
            // 
            // labelP
            // 
            labelP.AutoSize = true;
            labelP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelP.ForeColor = Color.Teal;
            labelP.Location = new Point(24, 12);
            labelP.Name = "labelP";
            labelP.Size = new Size(63, 15);
            labelP.TabIndex = 9;
            labelP.Text = "PARTNERI";
            // 
            // pnlListaDobavljaca
            // 
            pnlListaDobavljaca.AutoScroll = true;
            pnlListaDobavljaca.Location = new Point(24, 67);
            pnlListaDobavljaca.Name = "pnlListaDobavljaca";
            pnlListaDobavljaca.Size = new Size(551, 200);
            pnlListaDobavljaca.TabIndex = 0;
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNaslov.Location = new Point(280, 42);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(399, 37);
            lblNaslov.TabIndex = 2;
            lblNaslov.Text = "Artikli, kategorije i dobavljači";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(280, 27);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 9;
            label2.Text = "OPERATIVNI CENTAR";
            // 
            // ArtikliControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 232);
            Controls.Add(label2);
            Controls.Add(lblNaslov);
            Controls.Add(pnlDobavljaci);
            Controls.Add(pnlArtikli);
            Name = "ArtikliControl";
            Size = new Size(1581, 760);
            pnlArtikli.ResumeLayout(false);
            pnlArtikli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArtikli).EndInit();
            pnlDobavljaci.ResumeLayout(false);
            pnlDobavljaci.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlArtikli;
        private DataGridView dgvArtikli;
        private Panel pnlDobavljaci;
        private Panel pnlListaDobavljaca;
        private Label lblNaslov;
        private Label lblMaticniPodaci;
        private Label labelP;
        private Label lblA;
        private Label label1;
        private Label label2;
    }
}
