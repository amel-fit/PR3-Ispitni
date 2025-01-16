namespace FIT.WinForms._2202IB230046
{
    partial class frmNovaProstorijaIB230046
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
            pbLogo = new PictureBox();
            txtNaziv = new TextBox();
            txtOznaka = new TextBox();
            txtKapacitet = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSacuvaj = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.BorderStyle = BorderStyle.Fixed3D;
            pbLogo.Location = new Point(28, 54);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(273, 274);
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(343, 82);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(261, 27);
            txtNaziv.TabIndex = 1;
            // 
            // txtOznaka
            // 
            txtOznaka.Location = new Point(343, 171);
            txtOznaka.Name = "txtOznaka";
            txtOznaka.Size = new Size(159, 27);
            txtOznaka.TabIndex = 2;
            // 
            // txtKapacitet
            // 
            txtKapacitet.Location = new Point(534, 171);
            txtKapacitet.Name = "txtKapacitet";
            txtKapacitet.Size = new Size(81, 27);
            txtKapacitet.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 54);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "Naziv";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 148);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 4;
            label2.Text = "Oznaka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(534, 148);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 4;
            label3.Text = "Kapacitet";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(534, 272);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaProstorijaIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSacuvaj);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKapacitet);
            Controls.Add(txtOznaka);
            Controls.Add(txtNaziv);
            Controls.Add(pbLogo);
            Name = "frmNovaProstorijaIB230046";
            Text = "frmNovaProstorijaIB230046";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private TextBox txtNaziv;
        private TextBox txtOznaka;
        private TextBox txtKapacitet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSacuvaj;
        private ErrorProvider err;
    }
}