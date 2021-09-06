
namespace DLWMS.WinForms.BrojIndeksa
{
    partial class frmNoviScanIspitaBrojIndeks
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPredmeti = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.cbVaranje = new System.Windows.Forms.CheckBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnSpasi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predmet:";
            // 
            // cbPredmeti
            // 
            this.cbPredmeti.FormattingEnabled = true;
            this.cbPredmeti.Location = new System.Drawing.Point(16, 33);
            this.cbPredmeti.Name = "cbPredmeti";
            this.cbPredmeti.Size = new System.Drawing.Size(160, 24);
            this.cbPredmeti.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Napomena:";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(19, 96);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(293, 258);
            this.txtNapomena.TabIndex = 3;
            // 
            // cbVaranje
            // 
            this.cbVaranje.AutoSize = true;
            this.cbVaranje.Location = new System.Drawing.Point(19, 373);
            this.cbVaranje.Name = "cbVaranje";
            this.cbVaranje.Size = new System.Drawing.Size(136, 21);
            this.cbVaranje.TabIndex = 4;
            this.cbVaranje.Text = "Varanje na ispitu";
            this.cbVaranje.UseVisualStyleBackColor = true;
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(332, 33);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(279, 321);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 5;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Slika:";
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(536, 371);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 23);
            this.btnSpasi.TabIndex = 7;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // frmNoviScanIspitaBrojIndeks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 415);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.cbVaranje);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPredmeti);
            this.Controls.Add(this.label1);
            this.Name = "frmNoviScanIspitaBrojIndeks";
            this.Text = "frmNoviScanIspitaBrojIndeks";
            this.Load += new System.EventHandler(this.frmNoviScanIspitaBrojIndeks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPredmeti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.CheckBox cbVaranje;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Label label3;
    }
}