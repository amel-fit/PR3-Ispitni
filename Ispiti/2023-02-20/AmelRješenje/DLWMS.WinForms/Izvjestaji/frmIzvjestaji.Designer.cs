namespace DLWMS.WinForms.Izvjestaji
{
    partial class frmIzvjestaji
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
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            pictureBox1 = new PictureBox();
            lblListaPoruka = new Label();
            lblStudent = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.LocalReport.ReportEmbeddedResource = "DLWMS.WinForms.Izvjestaji.rptUvjerenje.rdlc";
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Margin = new Padding(3, 4, 3, 4);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(775, 618);
            reportViewer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._CE3651F1894B4CB1BE6925;
            pictureBox1.Location = new Point(12, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblListaPoruka
            // 
            lblListaPoruka.AutoSize = true;
            lblListaPoruka.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaPoruka.Location = new Point(256, 43);
            lblListaPoruka.Name = "lblListaPoruka";
            lblListaPoruka.Size = new Size(219, 40);
            lblListaPoruka.TabIndex = 2;
            lblListaPoruka.Text = "LISTA PORUKA";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudent.Location = new Point(272, 98);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(193, 20);
            lblStudent.TabIndex = 3;
            lblStudent.Text = "za studenta [Ime Prezime]";
            lblStudent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(751, 331);
            dataGridView1.TabIndex = 4;
            // 
            // frmIzvjestaji
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 618);
            Controls.Add(dataGridView1);
            Controls.Add(lblStudent);
            Controls.Add(lblListaPoruka);
            Controls.Add(pictureBox1);
            Controls.Add(reportViewer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmIzvjestaji";
            Text = "frmIzvjestaji";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PictureBox pictureBox1;
        private Label lblListaPoruka;
        private Label lblStudent;
        private DataGridView dataGridView1;
    }
}