namespace DLWMS.WinForms.IB230046
{
    partial class frmPretragaIB230046
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
            dgvStudenti = new DataGridView();
            cmbSpol = new ComboBox();
            lblSpol = new Label();
            lblOd = new Label();
            lblDo = new Label();
            dtpOd = new DateTimePicker();
            dtpDo = new DateTimePicker();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Uvjerenja = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, ImePrezime, Prosjek, DatumRodjenja, Aktivan, Uvjerenja });
            dgvStudenti.Location = new Point(12, 80);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 29;
            dgvStudenti.Size = new Size(849, 343);
            dgvStudenti.TabIndex = 0;
            dgvStudenti.CellClick += dgvStudenti_CellClick;
            // 
            // cmbSpol
            // 
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Items.AddRange(new object[] { "Muški", "Ženski" });
            cmbSpol.Location = new Point(57, 31);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(111, 28);
            cmbSpol.TabIndex = 1;
            cmbSpol.SelectedIndexChanged += RefreshResults;
            // 
            // lblSpol
            // 
            lblSpol.AutoSize = true;
            lblSpol.Location = new Point(12, 36);
            lblSpol.Name = "lblSpol";
            lblSpol.Size = new Size(39, 20);
            lblSpol.TabIndex = 2;
            lblSpol.Text = "Spol";
            // 
            // lblOd
            // 
            lblOd.AutoSize = true;
            lblOd.Location = new Point(174, 36);
            lblOd.Name = "lblOd";
            lblOd.Size = new Size(142, 20);
            lblOd.TabIndex = 3;
            lblOd.Text = "Rođen u periodu od";
            // 
            // lblDo
            // 
            lblDo.AutoSize = true;
            lblDo.Location = new Point(578, 36);
            lblDo.Name = "lblDo";
            lblDo.Size = new Size(27, 20);
            lblDo.TabIndex = 4;
            lblDo.Text = "do";
            // 
            // dtpOd
            // 
            dtpOd.Location = new Point(322, 31);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(250, 27);
            dtpOd.TabIndex = 5;
            dtpOd.ValueChanged += RefreshResults;
            // 
            // dtpDo
            // 
            dtpDo.Location = new Point(611, 31);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(250, 27);
            dtpDo.TabIndex = 6;
            dtpDo.ValueChanged += RefreshResults;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.DataPropertyName = "BrojIndeksa";
            BrojIndeksa.HeaderText = "Broj Indeksa";
            BrojIndeksa.MinimumWidth = 6;
            BrojIndeksa.Name = "BrojIndeksa";
            BrojIndeksa.ReadOnly = true;
            BrojIndeksa.Width = 125;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 6;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            Prosjek.Width = 125;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rođenja";
            DatumRodjenja.MinimumWidth = 6;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Width = 125;
            // 
            // Uvjerenja
            // 
            Uvjerenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uvjerenja.HeaderText = "";
            Uvjerenja.MinimumWidth = 6;
            Uvjerenja.Name = "Uvjerenja";
            Uvjerenja.ReadOnly = true;
            Uvjerenja.Text = "Uvjerenja";
            Uvjerenja.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 450);
            Controls.Add(dtpDo);
            Controls.Add(dtpOd);
            Controls.Add(lblDo);
            Controls.Add(lblOd);
            Controls.Add(lblSpol);
            Controls.Add(cmbSpol);
            Controls.Add(dgvStudenti);
            Name = "frmPretragaIB230046";
            Text = "frmPretragaIB230046";
            Load += frmPretragaIB230046_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudenti;
        private ComboBox cmbSpol;
        private Label lblSpol;
        private Label lblOd;
        private Label lblDo;
        private DateTimePicker dtpOd;
        private DateTimePicker dtpDo;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Uvjerenja;
    }
}