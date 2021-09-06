
namespace DLWMS.WinForms.BrojIndeksa
{
    partial class frmScanIspitaBrojIndeksa
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvSken = new System.Windows.Forms.DataGridView();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sken = new System.Windows.Forms.DataGridViewImageColumn();
            this.Varanje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSken)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled ispita za studenta: ";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(915, 13);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj sken";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvSken
            // 
            this.dgvSken.AllowUserToAddRows = false;
            this.dgvSken.AllowUserToDeleteRows = false;
            this.dgvSken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSken.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Korisnik,
            this.Predmet,
            this.Napomena,
            this.Sken,
            this.Varanje,
            this.Brisi});
            this.dgvSken.Location = new System.Drawing.Point(12, 42);
            this.dgvSken.Name = "dgvSken";
            this.dgvSken.ReadOnly = true;
            this.dgvSken.RowHeadersWidth = 51;
            this.dgvSken.RowTemplate.Height = 24;
            this.dgvSken.Size = new System.Drawing.Size(978, 321);
            this.dgvSken.TabIndex = 2;
            this.dgvSken.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSken_CellContentClick);
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Student";
            this.Korisnik.HeaderText = "Student";
            this.Korisnik.MinimumWidth = 6;
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            this.Korisnik.Width = 125;
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            this.Predmet.Width = 125;
            // 
            // Napomena
            // 
            this.Napomena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.MinimumWidth = 6;
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            // 
            // Sken
            // 
            this.Sken.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sken.DataPropertyName = "Sken";
            this.Sken.HeaderText = "Sken";
            this.Sken.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Sken.MinimumWidth = 6;
            this.Sken.Name = "Sken";
            this.Sken.ReadOnly = true;
            // 
            // Varanje
            // 
            this.Varanje.DataPropertyName = "Varanje";
            this.Varanje.HeaderText = "Varanje";
            this.Varanje.MinimumWidth = 6;
            this.Varanje.Name = "Varanje";
            this.Varanje.ReadOnly = true;
            this.Varanje.Width = 125;
            // 
            // Brisi
            // 
            this.Brisi.HeaderText = "Brisi";
            this.Brisi.MinimumWidth = 6;
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Text = "Brisi";
            this.Brisi.UseColumnTextForButtonValue = true;
            this.Brisi.Width = 125;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(915, 369);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Printaj";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmScanIspitaBrojIndeksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 401);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvSken);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label1);
            this.Name = "frmScanIspitaBrojIndeksa";
            this.Text = "frmScanIspitaBrojIndeksa";
            this.Load += new System.EventHandler(this.frmScanIspitaBrojIndeksa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvSken;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewImageColumn Sken;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Varanje;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}