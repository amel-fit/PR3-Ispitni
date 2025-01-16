namespace FIT.WinForms._2202IB230046
{
    partial class frmNastavaIB230046
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
            cmbPredmet = new ComboBox();
            cmbDan = new ComboBox();
            cmbVrijeme = new ComboBox();
            btnDodaj = new Button();
            lblPredmet = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvNastave = new DataGridView();
            lblProstorija = new Label();
            err = new ErrorProvider(components);
            Predmet = new DataGridViewTextBoxColumn();
            Dan = new DataGridViewTextBoxColumn();
            Vrijeme = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvNastave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // cmbPredmet
            // 
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(12, 151);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(151, 28);
            cmbPredmet.TabIndex = 0;
            // 
            // cmbDan
            // 
            cmbDan.FormattingEnabled = true;
            cmbDan.Location = new Point(211, 151);
            cmbDan.Name = "cmbDan";
            cmbDan.Size = new Size(151, 28);
            cmbDan.TabIndex = 0;
            // 
            // cmbVrijeme
            // 
            cmbVrijeme.FormattingEnabled = true;
            cmbVrijeme.Location = new Point(389, 151);
            cmbVrijeme.Name = "cmbVrijeme";
            cmbVrijeme.Size = new Size(151, 28);
            cmbVrijeme.TabIndex = 0;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(657, 151);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // lblPredmet
            // 
            lblPredmet.AutoSize = true;
            lblPredmet.Location = new Point(12, 130);
            lblPredmet.Name = "lblPredmet";
            lblPredmet.Size = new Size(65, 20);
            lblPredmet.TabIndex = 2;
            lblPredmet.Text = "Predmet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 130);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "Dan:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 130);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "Vrijeme";
            // 
            // dgvNastave
            // 
            dgvNastave.AllowUserToAddRows = false;
            dgvNastave.AllowUserToDeleteRows = false;
            dgvNastave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNastave.Columns.AddRange(new DataGridViewColumn[] { Predmet, Dan, Vrijeme });
            dgvNastave.Location = new Point(12, 201);
            dgvNastave.Name = "dgvNastave";
            dgvNastave.ReadOnly = true;
            dgvNastave.RowHeadersWidth = 51;
            dgvNastave.RowTemplate.Height = 29;
            dgvNastave.Size = new Size(766, 358);
            dgvNastave.TabIndex = 3;
            // 
            // lblProstorija
            // 
            lblProstorija.AutoSize = true;
            lblProstorija.Font = new Font("Segoe UI", 18F);
            lblProstorija.Location = new Point(27, 31);
            lblProstorija.Name = "lblProstorija";
            lblProstorija.Size = new Size(97, 41);
            lblProstorija.TabIndex = 4;
            lblProstorija.Text = "label1";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // Predmet
            // 
            Predmet.DataPropertyName = "PredmetTXT";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            Predmet.Width = 125;
            // 
            // Dan
            // 
            Dan.DataPropertyName = "Dan";
            Dan.HeaderText = "Dan";
            Dan.MinimumWidth = 6;
            Dan.Name = "Dan";
            Dan.ReadOnly = true;
            Dan.Width = 125;
            // 
            // Vrijeme
            // 
            Vrijeme.DataPropertyName = "VrijemeOdrzavanja";
            Vrijeme.HeaderText = "Vrijeme";
            Vrijeme.MinimumWidth = 6;
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            Vrijeme.Width = 125;
            // 
            // frmNastavaIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 587);
            Controls.Add(lblProstorija);
            Controls.Add(dgvNastave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblPredmet);
            Controls.Add(btnDodaj);
            Controls.Add(cmbVrijeme);
            Controls.Add(cmbDan);
            Controls.Add(cmbPredmet);
            Name = "frmNastavaIB230046";
            Text = "frmNastavaIB230046";
            ((System.ComponentModel.ISupportInitialize)dgvNastave).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPredmet;
        private ComboBox cmbDan;
        private ComboBox cmbVrijeme;
        private Button btnDodaj;
        private Label lblPredmet;
        private Label label2;
        private Label label3;
        private DataGridView dgvNastave;
        private Label lblProstorija;
        private ErrorProvider err;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Dan;
        private DataGridViewTextBoxColumn Vrijeme;
    }
}