namespace DLWMS.WinForms.IB230046
{
    partial class frmNovaPorukaIB230046
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
            dtpValidnost = new DateTimePicker();
            cbPredmet = new ComboBox();
            lblValidnost = new Label();
            lblPredmet = new Label();
            lblSadrzaj = new Label();
            rtSadrzaj = new RichTextBox();
            pbSlika = new PictureBox();
            lblSlika = new Label();
            fdSlikaSelect = new OpenFileDialog();
            btnPosalji = new Button();
            btnOdustani = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(12, 123);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(250, 27);
            dtpValidnost.TabIndex = 11;
            // 
            // cbPredmet
            // 
            cbPredmet.DisplayMember = "Naziv";
            cbPredmet.FormattingEnabled = true;
            cbPredmet.Location = new Point(12, 59);
            cbPredmet.Name = "cbPredmet";
            cbPredmet.Size = new Size(250, 28);
            cbPredmet.TabIndex = 10;
            // 
            // lblValidnost
            // 
            lblValidnost.AutoSize = true;
            lblValidnost.Location = new Point(12, 100);
            lblValidnost.Name = "lblValidnost";
            lblValidnost.Size = new Size(83, 20);
            lblValidnost.TabIndex = 8;
            lblValidnost.Text = "Validna do:";
            // 
            // lblPredmet
            // 
            lblPredmet.AutoSize = true;
            lblPredmet.Location = new Point(12, 36);
            lblPredmet.Name = "lblPredmet";
            lblPredmet.Size = new Size(68, 20);
            lblPredmet.TabIndex = 7;
            lblPredmet.Text = "Predmet:";
            // 
            // lblSadrzaj
            // 
            lblSadrzaj.AutoSize = true;
            lblSadrzaj.Location = new Point(12, 166);
            lblSadrzaj.Name = "lblSadrzaj";
            lblSadrzaj.Size = new Size(61, 20);
            lblSadrzaj.TabIndex = 7;
            lblSadrzaj.Text = "Sadržaj:";
            // 
            // rtSadrzaj
            // 
            rtSadrzaj.Location = new Point(12, 198);
            rtSadrzaj.Name = "rtSadrzaj";
            rtSadrzaj.Size = new Size(250, 229);
            rtSadrzaj.TabIndex = 12;
            rtSadrzaj.Text = "";
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.Fixed3D;
            pbSlika.Location = new Point(310, 59);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(478, 368);
            pbSlika.TabIndex = 13;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // lblSlika
            // 
            lblSlika.AutoSize = true;
            lblSlika.Location = new Point(310, 36);
            lblSlika.Name = "lblSlika";
            lblSlika.Size = new Size(43, 20);
            lblSlika.TabIndex = 7;
            lblSlika.Text = "Slika:";
            // 
            // btnPosalji
            // 
            btnPosalji.Location = new Point(694, 444);
            btnPosalji.Name = "btnPosalji";
            btnPosalji.Size = new Size(94, 29);
            btnPosalji.TabIndex = 14;
            btnPosalji.Text = "Posalji";
            btnPosalji.UseVisualStyleBackColor = true;
            btnPosalji.Click += btnPosalji_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(578, 444);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(94, 29);
            btnOdustani.TabIndex = 14;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaPorukaIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 485);
            Controls.Add(btnOdustani);
            Controls.Add(btnPosalji);
            Controls.Add(pbSlika);
            Controls.Add(rtSadrzaj);
            Controls.Add(dtpValidnost);
            Controls.Add(cbPredmet);
            Controls.Add(lblValidnost);
            Controls.Add(lblSadrzaj);
            Controls.Add(lblSlika);
            Controls.Add(lblPredmet);
            Name = "frmNovaPorukaIB230046";
            Text = "frmNovaPorukaIB230046";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpValidnost;
        private ComboBox cbPredmet;
        private Label lblValidnost;
        private Label lblPredmet;
        private Label lblSadrzaj;
        private RichTextBox rtSadrzaj;
        private PictureBox pbSlika;
        private Label lblSlika;
        private OpenFileDialog fdSlikaSelect;
        private Button btnPosalji;
        private Button btnOdustani;
        private ErrorProvider err;
    }
}