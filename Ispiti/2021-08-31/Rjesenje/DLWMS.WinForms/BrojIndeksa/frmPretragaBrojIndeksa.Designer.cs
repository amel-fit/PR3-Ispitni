
namespace DLWMS.WinForms.BrojIndeksa
{
    partial class frmPretragaBrojIndeksa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dgvStudentiStatistika = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polozeni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Broj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispiti = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.lblNajveci = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThreading = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.Label();
            this.btnThreading = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiStatistika)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ili prezime:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(119, 23);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(970, 22);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // dgvStudentiStatistika
            // 
            this.dgvStudentiStatistika.AllowUserToAddRows = false;
            this.dgvStudentiStatistika.AllowUserToDeleteRows = false;
            this.dgvStudentiStatistika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentiStatistika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Polozeni,
            this.Broj,
            this.Prosjek,
            this.Ispiti});
            this.dgvStudentiStatistika.Location = new System.Drawing.Point(15, 51);
            this.dgvStudentiStatistika.Name = "dgvStudentiStatistika";
            this.dgvStudentiStatistika.ReadOnly = true;
            this.dgvStudentiStatistika.RowHeadersWidth = 51;
            this.dgvStudentiStatistika.RowTemplate.Height = 24;
            this.dgvStudentiStatistika.Size = new System.Drawing.Size(1074, 272);
            this.dgvStudentiStatistika.TabIndex = 2;
            this.dgvStudentiStatistika.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentiStatistika_CellContentClick);
            // 
            // Student
            // 
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.MinimumWidth = 6;
            this.Student.Name = "Student";
            this.Student.Width = 125;
            // 
            // Polozeni
            // 
            this.Polozeni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Polozeni.DataPropertyName = "Polozeni";
            this.Polozeni.HeaderText = "Polozeni";
            this.Polozeni.MinimumWidth = 6;
            this.Polozeni.Name = "Polozeni";
            // 
            // Broj
            // 
            this.Broj.DataPropertyName = "Broj";
            this.Broj.HeaderText = "Broj";
            this.Broj.MinimumWidth = 6;
            this.Broj.Name = "Broj";
            this.Broj.Width = 125;
            // 
            // Prosjek
            // 
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.MinimumWidth = 6;
            this.Prosjek.Name = "Prosjek";
            this.Prosjek.Width = 125;
            // 
            // Ispiti
            // 
            this.Ispiti.HeaderText = "Ispiti";
            this.Ispiti.MinimumWidth = 6;
            this.Ispiti.Name = "Ispiti";
            this.Ispiti.Text = "Ispiti";
            this.Ispiti.UseColumnTextForButtonValue = true;
            this.Ispiti.Width = 125;
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(12, 326);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(174, 17);
            this.lblProsjek.TabIndex = 3;
            this.lblProsjek.Text = "Prosjek prikazanih ocjena:";
            // 
            // lblNajveci
            // 
            this.lblNajveci.AutoSize = true;
            this.lblNajveci.Location = new System.Drawing.Point(531, 326);
            this.lblNajveci.Name = "lblNajveci";
            this.lblNajveci.Size = new System.Drawing.Size(162, 17);
            this.lblNajveci.TabIndex = 4;
            this.lblNajveci.Text = "Najveci prosjek ostvario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThreading);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.txtThreading);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1074, 244);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threading:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unesite sadrzaj:";
            // 
            // txtThreading
            // 
            this.txtThreading.Location = new System.Drawing.Point(19, 42);
            this.txtThreading.Multiline = true;
            this.txtThreading.Name = "txtThreading";
            this.txtThreading.Size = new System.Drawing.Size(1049, 108);
            this.txtThreading.TabIndex = 1;
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = true;
            this.txtInfo.Location = new System.Drawing.Point(19, 157);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(87, 17);
            this.txtInfo.TabIndex = 2;
            this.txtInfo.Text = "Sadrzaj info:";
            // 
            // btnThreading
            // 
            this.btnThreading.Location = new System.Drawing.Point(993, 157);
            this.btnThreading.Name = "btnThreading";
            this.btnThreading.Size = new System.Drawing.Size(75, 23);
            this.btnThreading.TabIndex = 3;
            this.btnThreading.Text = "Generisi";
            this.btnThreading.UseVisualStyleBackColor = true;
            this.btnThreading.Click += new System.EventHandler(this.btnThreading_Click);
            // 
            // frmPretragaBrojIndeksa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 620);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNajveci);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.dgvStudentiStatistika);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaBrojIndeksa";
            this.Text = "frmPretragaBrojIndeksa";
            this.Load += new System.EventHandler(this.frmPretragaBrojIndeksa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiStatistika)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView dgvStudentiStatistika;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.Label lblNajveci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polozeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Broj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosjek;
        private System.Windows.Forms.DataGridViewButtonColumn Ispiti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThreading;
        private System.Windows.Forms.Label txtInfo;
        private System.Windows.Forms.TextBox txtThreading;
        private System.Windows.Forms.Label label2;
    }
}