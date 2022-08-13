
namespace DLWMS.WinForms.IspitBrojIndeksa
{
    partial class frmKonsultacije
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnDodajZahtjev = new System.Windows.Forms.Button();
            this.dgvKonsultacije = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.grpDodavanjeZahtjeva = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.txtBrojZahtjeva = new System.Windows.Forms.TextBox();
            this.lblPredmet = new System.Windows.Forms.Label();
            this.lblBrojZahtjeva = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsultacije)).BeginInit();
            this.grpDodavanjeZahtjeva.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(9, 19);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(251, 17);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Lista zahtjeva za konsultacije studenta";
            // 
            // btnDodajZahtjev
            // 
            this.btnDodajZahtjev.Location = new System.Drawing.Point(887, 12);
            this.btnDodajZahtjev.Name = "btnDodajZahtjev";
            this.btnDodajZahtjev.Size = new System.Drawing.Size(128, 30);
            this.btnDodajZahtjev.TabIndex = 1;
            this.btnDodajZahtjev.Text = "Dodaj zahtjev";
            this.btnDodajZahtjev.UseVisualStyleBackColor = true;
            this.btnDodajZahtjev.Click += new System.EventHandler(this.btnDodajZahtjev_Click);
            // 
            // dgvKonsultacije
            // 
            this.dgvKonsultacije.AllowUserToAddRows = false;
            this.dgvKonsultacije.AllowUserToDeleteRows = false;
            this.dgvKonsultacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKonsultacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Vrijeme,
            this.Napomena,
            this.Brisi});
            this.dgvKonsultacije.Location = new System.Drawing.Point(12, 48);
            this.dgvKonsultacije.Name = "dgvKonsultacije";
            this.dgvKonsultacije.ReadOnly = true;
            this.dgvKonsultacije.RowHeadersWidth = 51;
            this.dgvKonsultacije.RowTemplate.Height = 24;
            this.dgvKonsultacije.Size = new System.Drawing.Size(1003, 255);
            this.dgvKonsultacije.TabIndex = 2;
            this.dgvKonsultacije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKonsultacije_CellContentClick);
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.MinimumWidth = 6;
            this.Predmet.Name = "Predmet";
            this.Predmet.ReadOnly = true;
            // 
            // Vrijeme
            // 
            this.Vrijeme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vrijeme.DataPropertyName = "VrijemeOdrzavanja";
            this.Vrijeme.HeaderText = "Vrijeme";
            this.Vrijeme.MinimumWidth = 6;
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.ReadOnly = true;
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
            // Brisi
            // 
            this.Brisi.HeaderText = "";
            this.Brisi.MinimumWidth = 6;
            this.Brisi.Name = "Brisi";
            this.Brisi.ReadOnly = true;
            this.Brisi.Text = "Briši";
            this.Brisi.UseColumnTextForButtonValue = true;
            this.Brisi.Width = 125;
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(941, 326);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(74, 31);
            this.btnPrintaj.TabIndex = 3;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // grpDodavanjeZahtjeva
            // 
            this.grpDodavanjeZahtjeva.Controls.Add(this.lblInfo);
            this.grpDodavanjeZahtjeva.Controls.Add(this.txtInfo);
            this.grpDodavanjeZahtjeva.Controls.Add(this.btnDodaj);
            this.grpDodavanjeZahtjeva.Controls.Add(this.cmbPredmeti);
            this.grpDodavanjeZahtjeva.Controls.Add(this.txtBrojZahtjeva);
            this.grpDodavanjeZahtjeva.Controls.Add(this.lblPredmet);
            this.grpDodavanjeZahtjeva.Controls.Add(this.lblBrojZahtjeva);
            this.grpDodavanjeZahtjeva.Location = new System.Drawing.Point(12, 320);
            this.grpDodavanjeZahtjeva.Name = "grpDodavanjeZahtjeva";
            this.grpDodavanjeZahtjeva.Size = new System.Drawing.Size(923, 180);
            this.grpDodavanjeZahtjeva.TabIndex = 4;
            this.grpDodavanjeZahtjeva.TabStop = false;
            this.grpDodavanjeZahtjeva.Text = "Dodavanje zahtjeva:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(175, 24);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 17);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Info:";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(178, 46);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(739, 117);
            this.txtInfo.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(76, 131);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(96, 32);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj =>";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(9, 91);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(163, 24);
            this.cmbPredmeti.TabIndex = 3;
            // 
            // txtBrojZahtjeva
            // 
            this.txtBrojZahtjeva.Location = new System.Drawing.Point(9, 46);
            this.txtBrojZahtjeva.Name = "txtBrojZahtjeva";
            this.txtBrojZahtjeva.Size = new System.Drawing.Size(163, 22);
            this.txtBrojZahtjeva.TabIndex = 2;
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Location = new System.Drawing.Point(6, 71);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(65, 17);
            this.lblPredmet.TabIndex = 1;
            this.lblPredmet.Text = "Predmet:";
            // 
            // lblBrojZahtjeva
            // 
            this.lblBrojZahtjeva.AutoSize = true;
            this.lblBrojZahtjeva.Location = new System.Drawing.Point(6, 24);
            this.lblBrojZahtjeva.Name = "lblBrojZahtjeva";
            this.lblBrojZahtjeva.Size = new System.Drawing.Size(94, 17);
            this.lblBrojZahtjeva.TabIndex = 0;
            this.lblBrojZahtjeva.Text = "Broj zahtjeva:";
            // 
            // frmKonsultacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 512);
            this.Controls.Add(this.grpDodavanjeZahtjeva);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.dgvKonsultacije);
            this.Controls.Add(this.btnDodajZahtjev);
            this.Controls.Add(this.lblStudent);
            this.Name = "frmKonsultacije";
            this.Text = "Broj ukupnih zapisa:";
            this.Load += new System.EventHandler(this.frmKonsultacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsultacije)).EndInit();
            this.grpDodavanjeZahtjeva.ResumeLayout(false);
            this.grpDodavanjeZahtjeva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnDodajZahtjev;
        private System.Windows.Forms.DataGridView dgvKonsultacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.GroupBox grpDodavanjeZahtjeva;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.TextBox txtBrojZahtjeva;
        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.Label lblBrojZahtjeva;
    }
}