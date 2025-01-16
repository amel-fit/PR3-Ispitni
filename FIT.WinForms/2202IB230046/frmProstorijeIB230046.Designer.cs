namespace FIT.WinForms._2202IB230046
{
    partial class frmProstorijeIB230046
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProstorije = new DataGridView();
            Logo = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            Oznaka = new DataGridViewTextBoxColumn();
            Kapacitet = new DataGridViewTextBoxColumn();
            BrPredmeta = new DataGridViewTextBoxColumn();
            btnNastava = new DataGridViewButtonColumn();
            btnPrisustvo = new DataGridViewButtonColumn();
            button1 = new Button();
            btnNovaProstorija = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProstorije).BeginInit();
            SuspendLayout();
            // 
            // dgvProstorije
            // 
            dgvProstorije.AllowUserToAddRows = false;
            dgvProstorije.AllowUserToDeleteRows = false;
            dgvProstorije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProstorije.Columns.AddRange(new DataGridViewColumn[] { Logo, Naziv, Oznaka, Kapacitet, BrPredmeta, btnNastava, btnPrisustvo });
            dgvProstorije.Location = new Point(3, 105);
            dgvProstorije.Name = "dgvProstorije";
            dgvProstorije.ReadOnly = true;
            dgvProstorije.RowHeadersWidth = 51;
            dgvProstorije.RowTemplate.Height = 29;
            dgvProstorije.Size = new Size(959, 297);
            dgvProstorije.TabIndex = 0;
            dgvProstorije.CellClick += dgvProstorije_CellClick;
            // 
            // Logo
            // 
            Logo.DataPropertyName = "LogoIMG";
            Logo.HeaderText = "Logo";
            Logo.MinimumWidth = 6;
            Logo.Name = "Logo";
            Logo.ReadOnly = true;
            Logo.Width = 125;
            // 
            // Naziv
            // 
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            Naziv.Width = 125;
            // 
            // Oznaka
            // 
            Oznaka.DataPropertyName = "Oznaka";
            Oznaka.HeaderText = "Oznaka";
            Oznaka.MinimumWidth = 6;
            Oznaka.Name = "Oznaka";
            Oznaka.ReadOnly = true;
            Oznaka.Width = 125;
            // 
            // Kapacitet
            // 
            Kapacitet.DataPropertyName = "Kapacitet";
            Kapacitet.HeaderText = "Kapacitet";
            Kapacitet.MinimumWidth = 6;
            Kapacitet.Name = "Kapacitet";
            Kapacitet.ReadOnly = true;
            Kapacitet.Width = 125;
            // 
            // BrPredmeta
            // 
            BrPredmeta.DataPropertyName = "BrPredmeta";
            BrPredmeta.HeaderText = "Br. Predmeta";
            BrPredmeta.MinimumWidth = 6;
            BrPredmeta.Name = "BrPredmeta";
            BrPredmeta.ReadOnly = true;
            BrPredmeta.Width = 125;
            // 
            // btnNastava
            // 
            btnNastava.HeaderText = "nastava";
            btnNastava.MinimumWidth = 6;
            btnNastava.Name = "btnNastava";
            btnNastava.ReadOnly = true;
            btnNastava.Text = "Nastava";
            btnNastava.UseColumnTextForButtonValue = true;
            btnNastava.Width = 125;
            // 
            // btnPrisustvo
            // 
            btnPrisustvo.HeaderText = "prisustvo";
            btnPrisustvo.MinimumWidth = 6;
            btnPrisustvo.Name = "btnPrisustvo";
            btnPrisustvo.ReadOnly = true;
            btnPrisustvo.Text = "Prisustvo";
            btnPrisustvo.UseColumnTextForButtonValue = true;
            btnPrisustvo.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(868, 408);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnNovaProstorija
            // 
            btnNovaProstorija.Location = new Point(868, 70);
            btnNovaProstorija.Name = "btnNovaProstorija";
            btnNovaProstorija.Size = new Size(94, 29);
            btnNovaProstorija.TabIndex = 2;
            btnNovaProstorija.Text = "Nova prostorija";
            btnNovaProstorija.UseVisualStyleBackColor = true;
            btnNovaProstorija.Click += btnNovaProstorija_Click_1;
            // 
            // frmProstorijeIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 450);
            Controls.Add(btnNovaProstorija);
            Controls.Add(button1);
            Controls.Add(dgvProstorije);
            Name = "frmProstorijeIB230046";
            Text = "frmProstorijeIB230046";
            ((System.ComponentModel.ISupportInitialize)dgvProstorije).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProstorije;
        private Button button1;
        private Button btnNovaProstorija;
        private DataGridViewImageColumn Logo;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Oznaka;
        private DataGridViewTextBoxColumn Kapacitet;
        private DataGridViewTextBoxColumn BrPredmeta;
        private DataGridViewButtonColumn btnNastava;
        private DataGridViewButtonColumn btnPrisustvo;
    }
}