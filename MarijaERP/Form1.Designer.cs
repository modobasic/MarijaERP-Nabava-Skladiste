namespace MarijaERP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlSidebar = new Panel();
            btnLotTrag = new Button();
            btnIzvjestaji = new Button();
            btnZalihe = new Button();
            btnZaprimanje = new Button();
            btnNarudzbe = new Button();
            btnArtikli = new Button();
            btnPregled = new Button();
            pictureBox1 = new PictureBox();
            lblSubtitle = new Label();
            lblAppName = new Label();
            pnlMain = new Panel();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(22, 35, 31);
            pnlSidebar.Controls.Add(btnLotTrag);
            pnlSidebar.Controls.Add(btnIzvjestaji);
            pnlSidebar.Controls.Add(btnZalihe);
            pnlSidebar.Controls.Add(btnZaprimanje);
            pnlSidebar.Controls.Add(btnNarudzbe);
            pnlSidebar.Controls.Add(btnArtikli);
            pnlSidebar.Controls.Add(btnPregled);
            pnlSidebar.Controls.Add(pictureBox1);
            pnlSidebar.Controls.Add(lblSubtitle);
            pnlSidebar.Controls.Add(lblAppName);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(252, 929);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLotTrag
            // 
            btnLotTrag.FlatAppearance.BorderSize = 0;
            btnLotTrag.FlatStyle = FlatStyle.Flat;
            btnLotTrag.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnLotTrag.ForeColor = Color.White;
            btnLotTrag.Location = new Point(0, 420);
            btnLotTrag.Name = "btnLotTrag";
            btnLotTrag.Padding = new Padding(70, 0, 0, 0);
            btnLotTrag.Size = new Size(252, 42);
            btnLotTrag.TabIndex = 9;
            btnLotTrag.Text = "LOT trag";
            btnLotTrag.TextAlign = ContentAlignment.MiddleLeft;
            btnLotTrag.UseVisualStyleBackColor = true;
            btnLotTrag.Click += btnLotTrag_Click;
            // 
            // btnIzvjestaji
            // 
            btnIzvjestaji.FlatAppearance.BorderSize = 0;
            btnIzvjestaji.FlatStyle = FlatStyle.Flat;
            btnIzvjestaji.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnIzvjestaji.ForeColor = Color.White;
            btnIzvjestaji.Location = new Point(0, 370);
            btnIzvjestaji.Name = "btnIzvjestaji";
            btnIzvjestaji.Padding = new Padding(70, 0, 0, 0);
            btnIzvjestaji.Size = new Size(252, 42);
            btnIzvjestaji.TabIndex = 8;
            btnIzvjestaji.Text = "Izvještaji";
            btnIzvjestaji.TextAlign = ContentAlignment.MiddleLeft;
            btnIzvjestaji.UseVisualStyleBackColor = true;
            btnIzvjestaji.Click += btnIzvjestaji_Click;
            // 
            // btnZalihe
            // 
            btnZalihe.FlatAppearance.BorderSize = 0;
            btnZalihe.FlatStyle = FlatStyle.Flat;
            btnZalihe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnZalihe.ForeColor = Color.White;
            btnZalihe.Location = new Point(0, 320);
            btnZalihe.Name = "btnZalihe";
            btnZalihe.Padding = new Padding(70, 0, 0, 0);
            btnZalihe.Size = new Size(252, 42);
            btnZalihe.TabIndex = 7;
            btnZalihe.Text = "Zalihe";
            btnZalihe.TextAlign = ContentAlignment.MiddleLeft;
            btnZalihe.UseVisualStyleBackColor = true;
            btnZalihe.Click += btnZalihe_Click;
            // 
            // btnZaprimanje
            // 
            btnZaprimanje.FlatAppearance.BorderSize = 0;
            btnZaprimanje.FlatStyle = FlatStyle.Flat;
            btnZaprimanje.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnZaprimanje.ForeColor = Color.White;
            btnZaprimanje.Location = new Point(0, 270);
            btnZaprimanje.Name = "btnZaprimanje";
            btnZaprimanje.Padding = new Padding(70, 0, 0, 0);
            btnZaprimanje.Size = new Size(252, 42);
            btnZaprimanje.TabIndex = 6;
            btnZaprimanje.Text = "Zaprimanje";
            btnZaprimanje.TextAlign = ContentAlignment.MiddleLeft;
            btnZaprimanje.UseVisualStyleBackColor = true;
            btnZaprimanje.Click += btnZaprimanje_Click;
            // 
            // btnNarudzbe
            // 
            btnNarudzbe.FlatAppearance.BorderSize = 0;
            btnNarudzbe.FlatStyle = FlatStyle.Flat;
            btnNarudzbe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnNarudzbe.ForeColor = Color.White;
            btnNarudzbe.Location = new Point(0, 220);
            btnNarudzbe.Name = "btnNarudzbe";
            btnNarudzbe.Padding = new Padding(70, 0, 0, 0);
            btnNarudzbe.Size = new Size(252, 42);
            btnNarudzbe.TabIndex = 5;
            btnNarudzbe.Text = "Narudžbe";
            btnNarudzbe.TextAlign = ContentAlignment.MiddleLeft;
            btnNarudzbe.UseVisualStyleBackColor = true;
            btnNarudzbe.Click += btnNarudzbe_Click;
            // 
            // btnArtikli
            // 
            btnArtikli.BackColor = Color.FromArgb(22, 35, 31);
            btnArtikli.FlatAppearance.BorderSize = 0;
            btnArtikli.FlatStyle = FlatStyle.Flat;
            btnArtikli.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnArtikli.ForeColor = Color.White;
            btnArtikli.Location = new Point(0, 170);
            btnArtikli.Name = "btnArtikli";
            btnArtikli.Padding = new Padding(70, 0, 0, 0);
            btnArtikli.Size = new Size(252, 42);
            btnArtikli.TabIndex = 4;
            btnArtikli.Text = "Artikli";
            btnArtikli.TextAlign = ContentAlignment.MiddleLeft;
            btnArtikli.UseVisualStyleBackColor = false;
            btnArtikli.Click += btnArtikli_Click;
            // 
            // btnPregled
            // 
            btnPregled.FlatAppearance.BorderSize = 0;
            btnPregled.FlatStyle = FlatStyle.Flat;
            btnPregled.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnPregled.ForeColor = Color.White;
            btnPregled.Location = new Point(0, 120);
            btnPregled.Name = "btnPregled";
            btnPregled.Padding = new Padding(70, 0, 0, 0);
            btnPregled.Size = new Size(252, 42);
            btnPregled.TabIndex = 3;
            btnPregled.Text = "Pregled";
            btnPregled.TextAlign = ContentAlignment.MiddleLeft;
            btnPregled.UseVisualStyleBackColor = true;
            btnPregled.Click += btnPregled_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblSubtitle.ForeColor = Color.WhiteSmoke;
            lblSubtitle.Location = new Point(99, 51);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(101, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Nabava i skladište";
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblAppName.ForeColor = Color.NavajoWhite;
            lblAppName.Location = new Point(99, 30);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(88, 21);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "MarijaERP";
            // 
            // pnlMain
            // 
            pnlMain.BorderStyle = BorderStyle.Fixed3D;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1721, 929);
            pnlMain.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 240, 232);
            ClientSize = new Size(1721, 929);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlMain);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarijaERP | Nabava i skladište";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblAppName;
        private Panel pnlMain;
        private Label lblSubtitle;
        private PictureBox pictureBox1;
        private Button btnLotTrag;
        private Button btnIzvjestaji;
        private Button btnZalihe;
        private Button btnZaprimanje;
        private Button btnNarudzbe;
        private Button btnArtikli;
        private Button btnPregled;
    }
}
