namespace FIT.WinForms._2202IB230046
{
    partial class frmPrisustvoIB230046
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
            lblProstorija = new Label();
            lblCounter = new Label();
            cmbNastava = new ComboBox();
            cmbStudent = new ComboBox();
            btnDodaj = new Button();
            dgvPrisustva = new DataGridView();
            Oznaka = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            gbGenerator = new GroupBox();
            rtInfo = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            btnGenerisi = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPrisustva).BeginInit();
            gbGenerator.SuspendLayout();
            SuspendLayout();
            // 
            // lblProstorija
            // 
            lblProstorija.AutoSize = true;
            lblProstorija.Location = new Point(39, 46);
            lblProstorija.Name = "lblProstorija";
            lblProstorija.Size = new Size(50, 20);
            lblProstorija.TabIndex = 0;
            lblProstorija.Text = "label1";
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Location = new Point(654, 46);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(50, 20);
            lblCounter.TabIndex = 0;
            lblCounter.Text = "label1";
            // 
            // cmbNastava
            // 
            cmbNastava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNastava.FormattingEnabled = true;
            cmbNastava.Location = new Point(39, 82);
            cmbNastava.Name = "cmbNastava";
            cmbNastava.Size = new Size(245, 28);
            cmbNastava.TabIndex = 1;
            cmbNastava.SelectedIndexChanged += cmbNastava_SelectedIndexChanged;
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(301, 82);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(252, 28);
            cmbStudent.TabIndex = 1;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(621, 82);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvPrisustva
            // 
            dgvPrisustva.AllowUserToAddRows = false;
            dgvPrisustva.AllowUserToDeleteRows = false;
            dgvPrisustva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrisustva.Columns.AddRange(new DataGridViewColumn[] { Oznaka, Student });
            dgvPrisustva.Location = new Point(39, 129);
            dgvPrisustva.Name = "dgvPrisustva";
            dgvPrisustva.ReadOnly = true;
            dgvPrisustva.RowHeadersWidth = 51;
            dgvPrisustva.RowTemplate.Height = 29;
            dgvPrisustva.Size = new Size(676, 188);
            dgvPrisustva.TabIndex = 3;
            // 
            // Oznaka
            // 
            Oznaka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Oznaka.DataPropertyName = "OznakaTXT";
            Oznaka.HeaderText = "Predmet, prostorija, vrijeme";
            Oznaka.MinimumWidth = 6;
            Oznaka.Name = "Oznaka";
            Oznaka.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "StudentTXT";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // gbGenerator
            // 
            gbGenerator.Controls.Add(rtInfo);
            gbGenerator.Controls.Add(label2);
            gbGenerator.Controls.Add(label1);
            gbGenerator.Controls.Add(btnGenerisi);
            gbGenerator.Controls.Add(textBox1);
            gbGenerator.Location = new Point(39, 355);
            gbGenerator.Name = "gbGenerator";
            gbGenerator.Size = new Size(676, 251);
            gbGenerator.TabIndex = 4;
            gbGenerator.TabStop = false;
            gbGenerator.Text = "Generator";
            // 
            // rtInfo
            // 
            rtInfo.Location = new Point(21, 125);
            rtInfo.Name = "rtInfo";
            rtInfo.Size = new Size(621, 120);
            rtInfo.TabIndex = 3;
            rtInfo.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 102);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "Info:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 52);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 2;
            label1.Text = "Broj:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(190, 44);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 1;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(76, 27);
            textBox1.TabIndex = 0;
            // 
            // frmPrisustvoIB230046
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 630);
            Controls.Add(gbGenerator);
            Controls.Add(dgvPrisustva);
            Controls.Add(btnDodaj);
            Controls.Add(cmbStudent);
            Controls.Add(cmbNastava);
            Controls.Add(lblCounter);
            Controls.Add(lblProstorija);
            Name = "frmPrisustvoIB230046";
            Text = "frmPrisustvoIB230046";
            ((System.ComponentModel.ISupportInitialize)dgvPrisustva).EndInit();
            gbGenerator.ResumeLayout(false);
            gbGenerator.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProstorija;
        private Label lblCounter;
        private ComboBox cmbNastava;
        private ComboBox cmbStudent;
        private Button btnDodaj;
        private DataGridView dgvPrisustva;
        private GroupBox gbGenerator;
        private RichTextBox rtInfo;
        private Label label2;
        private Label label1;
        private Button btnGenerisi;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Oznaka;
        private DataGridViewTextBoxColumn Student;
    }
}