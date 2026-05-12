namespace MarijaERP
{
    partial class IzvjestajiControl
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
            panel1 = new Panel();
            dgvOtvoreneStavke = new DataGridView();
            label13 = new Label();
            label12 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pnlVrijednostKategorije = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOtvoreneStavke).BeginInit();
            panel2.SuspendLayout();
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
            lblNaslov.Size = new Size(246, 37);
            lblNaslov.TabIndex = 14;
            lblNaslov.Text = "Poslovni izvještaji";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvOtvoreneStavke);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Location = new Point(280, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 368);
            panel1.TabIndex = 17;
            // 
            // dgvOtvoreneStavke
            // 
            dgvOtvoreneStavke.BackgroundColor = Color.White;
            dgvOtvoreneStavke.BorderStyle = BorderStyle.None;
            dgvOtvoreneStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOtvoreneStavke.Location = new Point(31, 76);
            dgvOtvoreneStavke.Name = "dgvOtvoreneStavke";
            dgvOtvoreneStavke.Size = new Size(984, 259);
            dgvOtvoreneStavke.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label13.Location = new Point(20, 31);
            label13.Name = "label13";
            label13.Size = new Size(152, 25);
            label13.TabIndex = 15;
            label13.Text = "Otvorene stavke";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(20, 16);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 12;
            label12.Text = "NABAVA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pnlVrijednostKategorije);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(280, 481);
            panel2.Name = "panel2";
            panel2.Size = new Size(606, 354);
            panel2.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(20, 31);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 15;
            label1.Text = "Zaliha po kategoriji";
            // 
            // pnlVrijednostKategorije
            // 
            pnlVrijednostKategorije.BackColor = Color.White;
            pnlVrijednostKategorije.Location = new Point(31, 77);
            pnlVrijednostKategorije.Name = "pnlVrijednostKategorije";
            pnlVrijednostKategorije.Size = new Size(543, 251);
            pnlVrijednostKategorije.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(20, 16);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 12;
            label3.Text = "VRIJEDNOST";
            // 
            // IzvjestajiControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 232);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblNaslov);
            Controls.Add(label2);
            Name = "IzvjestajiControl";
            Size = new Size(1625, 859);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOtvoreneStavke).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lblNaslov;
        private Panel panel1;
        private DataGridView dgvOtvoreneStavke;
        private Label label13;
        private Label label12;
        private Panel panel2;
        private Label label1;
        private Panel pnlVrijednostKategorije;
        private Label label3;
    }
}
