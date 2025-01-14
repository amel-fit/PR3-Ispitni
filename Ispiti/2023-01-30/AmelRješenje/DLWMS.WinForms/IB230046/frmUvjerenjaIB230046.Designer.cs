namespace DLWMS.WinForms.IB230046
{
    partial class frmUvjerenjaIB230046
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
            btnNoviZahtjev = new Button();
            dgvUvjerenja = new DataGridView();
            Datum = new DataGridViewTextBoxColumn();
            Vrsta = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Printano = new DataGridViewCheckBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            Printaj = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            btnDodaj = new Button();
            txtBroj = new TextBox();
            txtSvrha = new TextBox();
            cmbVrsta = new ComboBox();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnNoviZahtjev
            // 
            btnNoviZahtjev.Location = new Point(950, 21);
            btnNoviZahtjev.Name = "btnNoviZahtjev";
            btnNoviZahtjev.Size = new Size(124, 29);
            btnNoviZahtjev.TabIndex = 0;
            btnNoviZahtjev.Text = "Novi zahtjev";
            btnNoviZahtjev.UseVisualStyleBackColor = true;
            btnNoviZahtjev.Click += btnNoviZahtjev_Click;
            // 
            // dgvUvjerenja
            // 
            dgvUvjerenja.AllowUserToAddRows = false;
            dgvUvjerenja.AllowUserToDeleteRows = false;
            dgvUvjerenja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUvjerenja.Columns.AddRange(new DataGridViewColumn[] { Datum, Vrsta, Svrha, Uplatnica, Printano, Brisi, Printaj });
            dgvUvjerenja.Location = new Point(12, 56);
            dgvUvjerenja.Name = "dgvUvjerenja";
            dgvUvjerenja.ReadOnly = true;
            dgvUvjerenja.RowHeadersWidth = 51;
            dgvUvjerenja.RowTemplate.Height = 29;
            dgvUvjerenja.Size = new Size(1062, 184);
            dgvUvjerenja.TabIndex = 1;
            dgvUvjerenja.CellClick += dgvUvjerenja_CellClick;
            // 
            // Datum
            // 
            Datum.DataPropertyName = "DatumKreiranja";
            Datum.HeaderText = "Datum";
            Datum.MinimumWidth = 6;
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            Datum.Width = 125;
            // 
            // Vrsta
            // 
            Vrsta.DataPropertyName = "Vrsta";
            Vrsta.HeaderText = "Vrsta";
            Vrsta.MinimumWidth = 6;
            Vrsta.Name = "Vrsta";
            Vrsta.ReadOnly = true;
            Vrsta.Width = 125;
            // 
            // Svrha
            // 
            Svrha.DataPropertyName = "Svrha";
            Svrha.HeaderText = "Svrha";
            Svrha.MinimumWidth = 6;
            Svrha.Name = "Svrha";
            Svrha.ReadOnly = true;
            Svrha.Width = 125;
            // 
            // Uplatnica
            // 
            Uplatnica.DataPropertyName = "UplatnicaIMG";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.MinimumWidth = 6;
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            Uplatnica.Width = 125;
            // 
            // Printano
            // 
            Printano.DataPropertyName = "Printano";
            Printano.HeaderText = "Printano";
            Printano.MinimumWidth = 6;
            Printano.Name = "Printano";
            Printano.ReadOnly = true;
            Printano.Width = 125;
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
            // Printaj
            // 
            Printaj.HeaderText = "";
            Printaj.MinimumWidth = 6;
            Printaj.Name = "Printaj";
            Printaj.ReadOnly = true;
            Printaj.Text = "Printaj";
            Printaj.UseColumnTextForButtonValue = true;
            Printaj.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(txtSvrha);
            groupBox1.Controls.Add(cmbVrsta);
            groupBox1.Location = new Point(12, 246);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1062, 192);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje zahtjeva za izdavanjem uvjerenja";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(13, 80);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1049, 106);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(962, 45);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(821, 47);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(125, 27);
            txtBroj.TabIndex = 2;
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(422, 47);
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(364, 27);
            txtSvrha.TabIndex = 1;
            // 
            // cmbVrsta
            // 
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Items.AddRange(new object[] { "Status Studenta", "Presjek Ocjena" });
            cmbVrsta.Location = new Point(13, 46);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(378, 28);
            cmbVrsta.TabIndex = 0;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmUvjerenjaIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvUvjerenja);
            Controls.Add(btnNoviZahtjev);
            Name = "frmUvjerenjaIB230046";
            Text = "frmUvjerenjaIB230046";
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNoviZahtjev;
        private DataGridView dgvUvjerenja;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private Button btnDodaj;
        private TextBox txtBroj;
        private TextBox txtSvrha;
        private ComboBox cmbVrsta;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
        private ErrorProvider err;
    }
}