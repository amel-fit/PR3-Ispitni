namespace DLWMS.WinForms.IB210000
{
    partial class frmNovoUvjerenjeIB210000
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
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSvrha = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta uvjerenja:";
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Location = new System.Drawing.Point(12, 27);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(218, 23);
            this.cmbVrsta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Skenirana uplatnica:";
            // 
            // pbSlika
            // 
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlika.Location = new System.Drawing.Point(247, 27);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(394, 204);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 3;
            this.pbSlika.TabStop = false;
            this.pbSlika.DoubleClick += new System.EventHandler(this.pbSlika_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Svrha uvjerenja:";
            // 
            // txtSvrha
            // 
            this.txtSvrha.Location = new System.Drawing.Point(12, 81);
            this.txtSvrha.Multiline = true;
            this.txtSvrha.Name = "txtSvrha";
            this.txtSvrha.Size = new System.Drawing.Size(218, 192);
            this.txtSvrha.TabIndex = 5;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(566, 250);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmNovoUvjerenjeIB210000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 299);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtSvrha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVrsta);
            this.Controls.Add(this.label1);
            this.Name = "frmNovoUvjerenjeIB210000";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novi zahtjev za izdavanjem uvjerenja";
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cmbVrsta;
        private Label label2;
        private PictureBox pbSlika;
        private Label label3;
        private TextBox txtSvrha;
        private Button btnSacuvaj;
        private ErrorProvider err;
    }
}