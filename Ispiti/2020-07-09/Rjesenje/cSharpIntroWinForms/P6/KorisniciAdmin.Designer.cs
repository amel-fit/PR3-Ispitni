namespace cSharpIntroWinForms
{
    partial class KorisniciAdmin
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
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Polozeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.txtThreadInput = new System.Windows.Forms.TextBox();
            this.btnThreadSuma = new System.Windows.Forms.Button();
            this.btnPrintajPolozene = new System.Windows.Forms.Button();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.cbAdministrator = new System.Windows.Forms.CheckBox();
            this.btnSlike = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Spol,
            this.KorisnickoIme,
            this.Admin,
            this.Polozeni});
            this.dgvKorisnici.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvKorisnici.Location = new System.Drawing.Point(12, 41);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(666, 265);
            this.dgvKorisnici.TabIndex = 0;
            this.dgvKorisnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisnici_CellContentClick);
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisničko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            // 
            // Admin
            // 
            this.Admin.DataPropertyName = "Admin";
            this.Admin.HeaderText = "Admin";
            this.Admin.Name = "Admin";
            // 
            // Polozeni
            // 
            this.Polozeni.HeaderText = "Polozeni";
            this.Polozeni.Name = "Polozeni";
            this.Polozeni.Text = "Polozeni";
            this.Polozeni.UseColumnTextForButtonValue = true;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 15);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(379, 20);
            this.txtPretraga.TabIndex = 2;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // txtThreadInput
            // 
            this.txtThreadInput.Location = new System.Drawing.Point(12, 325);
            this.txtThreadInput.Name = "txtThreadInput";
            this.txtThreadInput.Size = new System.Drawing.Size(160, 20);
            this.txtThreadInput.TabIndex = 3;
            // 
            // btnThreadSuma
            // 
            this.btnThreadSuma.Location = new System.Drawing.Point(178, 323);
            this.btnThreadSuma.Name = "btnThreadSuma";
            this.btnThreadSuma.Size = new System.Drawing.Size(75, 23);
            this.btnThreadSuma.TabIndex = 4;
            this.btnThreadSuma.Text = "Suma";
            this.btnThreadSuma.UseVisualStyleBackColor = true;
            this.btnThreadSuma.Click += new System.EventHandler(this.btnThreadSuma_Click);
            // 
            // btnPrintajPolozene
            // 
            this.btnPrintajPolozene.Location = new System.Drawing.Point(488, 323);
            this.btnPrintajPolozene.Name = "btnPrintajPolozene";
            this.btnPrintajPolozene.Size = new System.Drawing.Size(190, 23);
            this.btnPrintajPolozene.TabIndex = 5;
            this.btnPrintajPolozene.Text = "Printaj Polozene";
            this.btnPrintajPolozene.UseVisualStyleBackColor = true;
            this.btnPrintajPolozene.Click += new System.EventHandler(this.btnPrintajPolozene_Click);
            // 
            // cmbSpol
            // 
            this.cmbSpol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Location = new System.Drawing.Point(407, 14);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(137, 21);
            this.cmbSpol.TabIndex = 6;
            this.cmbSpol.SelectedIndexChanged += new System.EventHandler(this.cmbSpol_SelectedIndexChanged);
            // 
            // cbAdministrator
            // 
            this.cbAdministrator.AutoSize = true;
            this.cbAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbAdministrator.Location = new System.Drawing.Point(550, 14);
            this.cbAdministrator.Name = "cbAdministrator";
            this.cbAdministrator.Size = new System.Drawing.Size(128, 24);
            this.cbAdministrator.TabIndex = 7;
            this.cbAdministrator.Text = "Administrator";
            this.cbAdministrator.UseVisualStyleBackColor = true;
            this.cbAdministrator.CheckedChanged += new System.EventHandler(this.cbAdministrator_CheckedChanged);
            // 
            // btnSlike
            // 
            this.btnSlike.Location = new System.Drawing.Point(327, 322);
            this.btnSlike.Name = "btnSlike";
            this.btnSlike.Size = new System.Drawing.Size(75, 23);
            this.btnSlike.TabIndex = 8;
            this.btnSlike.Text = "Slike";
            this.btnSlike.UseVisualStyleBackColor = true;
            this.btnSlike.Click += new System.EventHandler(this.btnSlike_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSuma.Location = new System.Drawing.Point(13, 352);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(240, 23);
            this.lblSuma.TabIndex = 9;
            this.lblSuma.Text = "Suma";
            // 
            // KorisniciAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 379);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btnSlike);
            this.Controls.Add(this.cbAdministrator);
            this.Controls.Add(this.cmbSpol);
            this.Controls.Add(this.btnPrintajPolozene);
            this.Controls.Add(this.btnThreadSuma);
            this.Controls.Add(this.txtThreadInput);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.dgvKorisnici);
            this.Name = "KorisniciAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KorisniciAdmin";
            this.Load += new System.EventHandler(this.KorisniciAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
        private System.Windows.Forms.DataGridViewButtonColumn Polozeni;
        private System.Windows.Forms.TextBox txtThreadInput;
        private System.Windows.Forms.Button btnThreadSuma;
        private System.Windows.Forms.Button btnPrintajPolozene;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.CheckBox cbAdministrator;
        private System.Windows.Forms.Button btnSlike;
        private System.Windows.Forms.Label lblSuma;
    }
}