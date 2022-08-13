
namespace DLWMS.WinForms.IspitBrojIndeksa
{
    partial class frmPretraga
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
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.lblGodinaStudija = new System.Windows.Forms.Label();
            this.cmbGodinaStudija = new System.Windows.Forms.ComboBox();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaStudija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProsjecnaOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konsultacije = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Location = new System.Drawing.Point(9, 9);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(101, 17);
            this.lblImePrezime.TabIndex = 0;
            this.lblImePrezime.Text = "Ime ili prezime:";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(116, 6);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(572, 22);
            this.txtImePrezime.TabIndex = 1;
            this.txtImePrezime.TextChanged += new System.EventHandler(this.txtImePrezime_TextChanged);
            // 
            // lblGodinaStudija
            // 
            this.lblGodinaStudija.AutoSize = true;
            this.lblGodinaStudija.Location = new System.Drawing.Point(711, 9);
            this.lblGodinaStudija.Name = "lblGodinaStudija";
            this.lblGodinaStudija.Size = new System.Drawing.Size(103, 17);
            this.lblGodinaStudija.TabIndex = 2;
            this.lblGodinaStudija.Text = "Godina studija:";
            // 
            // cmbGodinaStudija
            // 
            this.cmbGodinaStudija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodinaStudija.FormattingEnabled = true;
            this.cmbGodinaStudija.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbGodinaStudija.Location = new System.Drawing.Point(820, 6);
            this.cmbGodinaStudija.Name = "cmbGodinaStudija";
            this.cmbGodinaStudija.Size = new System.Drawing.Size(50, 24);
            this.cmbGodinaStudija.TabIndex = 3;
            this.cmbGodinaStudija.SelectedIndexChanged += new System.EventHandler(this.cmbGodinaStudija_SelectedIndexChanged);
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.GodinaStudija,
            this.ProsjecnaOcjena,
            this.Konsultacije});
            this.dgvStudenti.Location = new System.Drawing.Point(12, 34);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.RowTemplate.Height = 24;
            this.dgvStudenti.Size = new System.Drawing.Size(858, 271);
            this.dgvStudenti.TabIndex = 4;
            this.dgvStudenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudenti_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.MinimumWidth = 6;
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // GodinaStudija
            // 
            this.GodinaStudija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GodinaStudija.DataPropertyName = "GodinaStudija";
            this.GodinaStudija.HeaderText = "Godina studija";
            this.GodinaStudija.MinimumWidth = 6;
            this.GodinaStudija.Name = "GodinaStudija";
            this.GodinaStudija.ReadOnly = true;
            // 
            // ProsjecnaOcjena
            // 
            this.ProsjecnaOcjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProsjecnaOcjena.DataPropertyName = "ProsjecnaOcjena";
            this.ProsjecnaOcjena.HeaderText = "Prosječna ocjena";
            this.ProsjecnaOcjena.MinimumWidth = 6;
            this.ProsjecnaOcjena.Name = "ProsjecnaOcjena";
            this.ProsjecnaOcjena.ReadOnly = true;
            // 
            // Konsultacije
            // 
            this.Konsultacije.HeaderText = "";
            this.Konsultacije.MinimumWidth = 6;
            this.Konsultacije.Name = "Konsultacije";
            this.Konsultacije.ReadOnly = true;
            this.Konsultacije.Text = "Konsultacije";
            this.Konsultacije.UseColumnTextForButtonValue = true;
            this.Konsultacije.Width = 125;
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 317);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.cmbGodinaStudija);
            this.Controls.Add(this.lblGodinaStudija);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.lblImePrezime);
            this.Name = "frmPretraga";
            this.Text = "frmPretraga";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Label lblGodinaStudija;
        private System.Windows.Forms.ComboBox cmbGodinaStudija;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaStudija;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProsjecnaOcjena;
        private System.Windows.Forms.DataGridViewButtonColumn Konsultacije;
    }
}