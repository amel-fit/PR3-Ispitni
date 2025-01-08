namespace DLWMS.WinForms
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
            dtpDatumDo = new DateTimePicker();
            cbOcjenaOd = new ComboBox();
            dgvStudenti = new DataGridView();
            cbOcjenaDo = new ComboBox();
            dtpDatumOd = new DateTimePicker();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            DatumPolaganja = new DataGridViewTextBoxColumn();
            btnPoruke = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Location = new Point(941, 12);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(250, 27);
            dtpDatumDo.TabIndex = 0;
            dtpDatumDo.ValueChanged += btnPretrazi_Click;
            // 
            // cbOcjenaOd
            // 
            cbOcjenaOd.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOcjenaOd.FormattingEnabled = true;
            cbOcjenaOd.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cbOcjenaOd.Location = new Point(21, 14);
            cbOcjenaOd.Name = "cbOcjenaOd";
            cbOcjenaOd.Size = new Size(82, 28);
            cbOcjenaOd.TabIndex = 1;
            cbOcjenaOd.SelectedIndexChanged += btnPretrazi_Click;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, Student, ImePrezime, Predmet, Ocjena, DatumPolaganja, btnPoruke });
            dgvStudenti.Location = new Point(21, 72);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 29;
            dgvStudenti.Size = new Size(1170, 366);
            dgvStudenti.TabIndex = 3;
            dgvStudenti.CellClick += dgvStudenti_CellClick;
            // 
            // cbOcjenaDo
            // 
            cbOcjenaDo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOcjenaDo.FormattingEnabled = true;
            cbOcjenaDo.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cbOcjenaDo.Location = new Point(121, 14);
            cbOcjenaDo.Name = "cbOcjenaDo";
            cbOcjenaDo.Size = new Size(82, 28);
            cbOcjenaDo.TabIndex = 1;
            cbOcjenaDo.SelectedIndexChanged += btnPretrazi_Click;
            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Location = new Point(685, 12);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(250, 27);
            dtpDatumOd.TabIndex = 0;
            dtpDatumOd.ValueChanged += btnPretrazi_Click;
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
            // Student
            // 
            Student.DataPropertyName = "Student";
            Student.HeaderText = "S";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            Student.Visible = false;
            Student.Width = 125;
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
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.MinimumWidth = 6;
            Ocjena.Name = "Ocjena";
            Ocjena.ReadOnly = true;
            Ocjena.Width = 125;
            // 
            // DatumPolaganja
            // 
            DatumPolaganja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPolaganja.DataPropertyName = "Datum";
            DatumPolaganja.HeaderText = "Datum Polaganja";
            DatumPolaganja.MinimumWidth = 6;
            DatumPolaganja.Name = "DatumPolaganja";
            DatumPolaganja.ReadOnly = true;
            // 
            // btnPoruke
            // 
            btnPoruke.HeaderText = "";
            btnPoruke.MinimumWidth = 6;
            btnPoruke.Name = "btnPoruke";
            btnPoruke.ReadOnly = true;
            btnPoruke.Text = "Poruke";
            btnPoruke.UseColumnTextForButtonValue = true;
            btnPoruke.Width = 125;
            // 
            // frmPretragaIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 450);
            Controls.Add(dgvStudenti);
            Controls.Add(cbOcjenaDo);
            Controls.Add(cbOcjenaOd);
            Controls.Add(dtpDatumOd);
            Controls.Add(dtpDatumDo);
            Name = "frmPretragaIB230046";
            Text = "frmPretragaIB230046";
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpDatumDo;
        private ComboBox cbOcjenaOd;
        private DataGridView dgvStudenti;
        private ComboBox cbOcjenaDo;
        private DateTimePicker dtpDatumOd;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn DatumPolaganja;
        private DataGridViewButtonColumn btnPoruke;
    }
}