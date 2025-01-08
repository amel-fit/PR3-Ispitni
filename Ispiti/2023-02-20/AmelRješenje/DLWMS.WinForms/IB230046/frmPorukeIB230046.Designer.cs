namespace DLWMS.WinForms.IB230046
{
    partial class frmPorukeIB230046
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
            components = new System.ComponentModel.Container();
            lblImeStudenta = new Label();
            btnNovaPoruka = new Button();
            dgvPoruke = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Sadrzaj = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Validnost = new DataGridViewTextBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            gbDodavanje = new GroupBox();
            btnDodaj = new Button();
            rtInfo = new RichTextBox();
            dtpValidnost = new DateTimePicker();
            cbPredmet = new ComboBox();
            txtBrojPoruka = new TextBox();
            lblValidnost = new Label();
            lblPredmet = new Label();
            lblInfo = new Label();
            lblBrojPoruka = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).BeginInit();
            gbDodavanje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // lblImeStudenta
            // 
            lblImeStudenta.AutoSize = true;
            lblImeStudenta.Location = new Point(12, 20);
            lblImeStudenta.Name = "lblImeStudenta";
            lblImeStudenta.Size = new Size(103, 20);
            lblImeStudenta.TabIndex = 0;
            lblImeStudenta.Text = "[ImeStudenta]";
            // 
            // btnNovaPoruka
            // 
            btnNovaPoruka.Location = new Point(810, 16);
            btnNovaPoruka.Name = "btnNovaPoruka";
            btnNovaPoruka.Size = new Size(123, 29);
            btnNovaPoruka.TabIndex = 1;
            btnNovaPoruka.Text = "Nova Poruka";
            btnNovaPoruka.UseVisualStyleBackColor = true;
            // 
            // dgvPoruke
            // 
            dgvPoruke.AllowUserToAddRows = false;
            dgvPoruke.AllowUserToDeleteRows = false;
            dgvPoruke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoruke.Columns.AddRange(new DataGridViewColumn[] { Predmet, Sadrzaj, Slika, Validnost, Brisi });
            dgvPoruke.Location = new Point(12, 56);
            dgvPoruke.Name = "dgvPoruke";
            dgvPoruke.ReadOnly = true;
            dgvPoruke.RowHeadersWidth = 51;
            dgvPoruke.RowTemplate.Height = 29;
            dgvPoruke.Size = new Size(921, 218);
            dgvPoruke.TabIndex = 2;
            dgvPoruke.CellClick += dgvPoruke_CellClick;
            // 
            // Predmet
            // 
            Predmet.DataPropertyName = "NazivPredmeta";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            Predmet.Width = 125;
            // 
            // Sadrzaj
            // 
            Sadrzaj.DataPropertyName = "Sadrzaj";
            Sadrzaj.HeaderText = "Sadržaj";
            Sadrzaj.MinimumWidth = 6;
            Sadrzaj.Name = "Sadrzaj";
            Sadrzaj.ReadOnly = true;
            Sadrzaj.Width = 125;
            // 
            // Slika
            // 
            Slika.DataPropertyName = "Slika";
            Slika.HeaderText = "Slika";
            Slika.MinimumWidth = 6;
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            Slika.Width = 125;
            // 
            // Validnost
            // 
            Validnost.DataPropertyName = "Validnost";
            Validnost.HeaderText = "Validnost";
            Validnost.MinimumWidth = 6;
            Validnost.Name = "Validnost";
            Validnost.ReadOnly = true;
            Validnost.Width = 125;
            // 
            // Brisi
            // 
            Brisi.HeaderText = "";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            Brisi.Width = 125;
            // 
            // gbDodavanje
            // 
            gbDodavanje.Controls.Add(btnDodaj);
            gbDodavanje.Controls.Add(rtInfo);
            gbDodavanje.Controls.Add(dtpValidnost);
            gbDodavanje.Controls.Add(cbPredmet);
            gbDodavanje.Controls.Add(txtBrojPoruka);
            gbDodavanje.Controls.Add(lblValidnost);
            gbDodavanje.Controls.Add(lblPredmet);
            gbDodavanje.Controls.Add(lblInfo);
            gbDodavanje.Controls.Add(lblBrojPoruka);
            gbDodavanje.Location = new Point(12, 294);
            gbDodavanje.Name = "gbDodavanje";
            gbDodavanje.Size = new Size(921, 272);
            gbDodavanje.TabIndex = 3;
            gbDodavanje.TabStop = false;
            gbDodavanje.Tag = "daw\u007f";
            gbDodavanje.Text = "Dodavanje poruka:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(9, 226);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(247, 29);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // rtInfo
            // 
            rtInfo.Location = new Point(280, 55);
            rtInfo.Name = "rtInfo";
            rtInfo.Size = new Size(626, 200);
            rtInfo.TabIndex = 6;
            rtInfo.Text = "";
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(6, 182);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(250, 27);
            dtpValidnost.TabIndex = 5;
            // 
            // cbPredmet
            // 
            cbPredmet.DisplayMember = "Naziv";
            cbPredmet.FormattingEnabled = true;
            cbPredmet.Location = new Point(6, 118);
            cbPredmet.Name = "cbPredmet";
            cbPredmet.Size = new Size(250, 28);
            cbPredmet.TabIndex = 4;
            // 
            // txtBrojPoruka
            // 
            txtBrojPoruka.Location = new Point(6, 55);
            txtBrojPoruka.Name = "txtBrojPoruka";
            txtBrojPoruka.Size = new Size(250, 27);
            txtBrojPoruka.TabIndex = 3;
            // 
            // lblValidnost
            // 
            lblValidnost.AutoSize = true;
            lblValidnost.Location = new Point(6, 159);
            lblValidnost.Name = "lblValidnost";
            lblValidnost.Size = new Size(83, 20);
            lblValidnost.TabIndex = 2;
            lblValidnost.Text = "Validna do:";
            // 
            // lblPredmet
            // 
            lblPredmet.AutoSize = true;
            lblPredmet.Location = new Point(6, 95);
            lblPredmet.Name = "lblPredmet";
            lblPredmet.Size = new Size(68, 20);
            lblPredmet.TabIndex = 1;
            lblPredmet.Text = "Predmet:";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(280, 32);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(38, 20);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Info:";
            // 
            // lblBrojPoruka
            // 
            lblBrojPoruka.AutoSize = true;
            lblBrojPoruka.Location = new Point(6, 32);
            lblBrojPoruka.Name = "lblBrojPoruka";
            lblBrojPoruka.Size = new Size(87, 20);
            lblBrojPoruka.TabIndex = 0;
            lblBrojPoruka.Text = "Broj Poruka:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPorukeIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 575);
            Controls.Add(gbDodavanje);
            Controls.Add(dgvPoruke);
            Controls.Add(btnNovaPoruka);
            Controls.Add(lblImeStudenta);
            Name = "frmPorukeIB230046";
            Text = "[BrojPoruka]";
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).EndInit();
            gbDodavanje.ResumeLayout(false);
            gbDodavanje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImeStudenta;
        private Button btnNovaPoruka;
        private DataGridView dgvPoruke;
        private GroupBox gbDodavanje;
        private RichTextBox rtInfo;
        private DateTimePicker dtpValidnost;
        private ComboBox cbPredmet;
        private TextBox txtBrojPoruka;
        private Label lblValidnost;
        private Label lblPredmet;
        private Label lblInfo;
        private Label lblBrojPoruka;
        private Button btnDodaj;
        private ErrorProvider err;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Sadrzaj;
        private DataGridViewImageColumn Slika;
        private DataGridViewTextBoxColumn Validnost;
        private DataGridViewButtonColumn Brisi;
    }
}