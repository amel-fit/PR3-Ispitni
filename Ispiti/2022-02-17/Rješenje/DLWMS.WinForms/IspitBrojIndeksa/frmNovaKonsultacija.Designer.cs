
namespace DLWMS.WinForms.IspitBrojIndeksa
{
    partial class frmNovaKonsultacija
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
            this.lblPredmet = new System.Windows.Forms.Label();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Location = new System.Drawing.Point(12, 9);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(131, 17);
            this.lblPredmet.TabIndex = 0;
            this.lblPredmet.Text = "Odaberite predmet:";
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(15, 29);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(291, 24);
            this.cmbPredmeti.TabIndex = 1;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(312, 30);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(326, 22);
            this.dtpDatum.TabIndex = 2;
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Location = new System.Drawing.Point(309, 9);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(202, 17);
            this.lblVrijeme.TabIndex = 3;
            this.lblVrijeme.Text = "Odaberite vrijeme konsultacija:";
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(12, 66);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(131, 17);
            this.lblNapomena.TabIndex = 4;
            this.lblNapomena.Text = "Unesite napomenu:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(558, 209);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(80, 30);
            this.btnSacuvaj.TabIndex = 5;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(472, 209);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(80, 30);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(12, 86);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(626, 117);
            this.txtNapomena.TabIndex = 7;
            // 
            // frmNovaKonsultacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 251);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lblVrijeme);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.lblPredmet);
            this.Name = "frmNovaKonsultacija";
            this.Text = "frmNovaKonsultacija";
            this.Load += new System.EventHandler(this.frmNovaKonsultacija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtNapomena;
    }
}