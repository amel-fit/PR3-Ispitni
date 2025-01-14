namespace DLWMS.WinForms.IB230046
{
    partial class frmNovoUvjerenjeIB230046
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
            cmbVrsta = new ComboBox();
            rtSvrha = new RichTextBox();
            pbUplatnica = new PictureBox();
            btnSacuvaj = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // cmbVrsta
            // 
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Items.AddRange(new object[] { "Status Studenta", "Presjek Ocjena" });
            cmbVrsta.Location = new Point(12, 43);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(352, 28);
            cmbVrsta.TabIndex = 1;
            // 
            // rtSvrha
            // 
            rtSvrha.Location = new Point(12, 112);
            rtSvrha.Name = "rtSvrha";
            rtSvrha.Size = new Size(352, 312);
            rtSvrha.TabIndex = 2;
            rtSvrha.Text = "";
            // 
            // pbUplatnica
            // 
            pbUplatnica.Location = new Point(400, 43);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(626, 346);
            pbUplatnica.TabIndex = 3;
            pbUplatnica.TabStop = false;
            pbUplatnica.Click += pbUplatnica_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(932, 395);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(400, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Uplatnica:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 5;
            label2.Text = "Vrsta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Svrha";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovoUvjerenjeIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbUplatnica);
            Controls.Add(rtSvrha);
            Controls.Add(cmbVrsta);
            Name = "frmNovoUvjerenjeIB230046";
            Text = "frmNovoUvjerenjeIB230046";
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbVrsta;
        private RichTextBox rtSvrha;
        private PictureBox pbUplatnica;
        private Button btnSacuvaj;
        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider err;
    }
}