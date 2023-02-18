namespace DLWMS.WinForms.IB210000
{
    partial class frmStudentInfoIB210000
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
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.lblProsjek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSlika
            // 
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlika.Location = new System.Drawing.Point(12, 12);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(275, 305);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 0;
            this.pbSlika.TabStop = false;
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImePrezime.Location = new System.Drawing.Point(12, 320);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(275, 37);
            this.lblImePrezime.TabIndex = 1;
            this.lblImePrezime.Text = "Ime prezime";
            this.lblImePrezime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProsjek
            // 
            this.lblProsjek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProsjek.Location = new System.Drawing.Point(12, 357);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(267, 24);
            this.lblProsjek.TabIndex = 2;
            this.lblProsjek.Text = "Prosjek";
            this.lblProsjek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStudentInfoIB210000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 392);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.lblImePrezime);
            this.Controls.Add(this.pbSlika);
            this.Name = "frmStudentInfoIB210000";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Indeks";
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbSlika;
        internal Label lblImePrezime;
        private Label lblProsjek;
    }
}