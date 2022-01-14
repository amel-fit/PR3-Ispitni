
namespace cSharpIntroWinForms.IB200002
{
    partial class frmIzvjesceIB200002
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dsPorukeTabelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPoruke = new cSharpIntroWinForms.IB200002.dsPoruke();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dsPorukeTabelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPoruke)).BeginInit();
            this.SuspendLayout();
            // 
            // dsPorukeTabelaBindingSource
            // 
            this.dsPorukeTabelaBindingSource.DataMember = "dsPorukeTabela";
            this.dsPorukeTabelaBindingSource.DataSource = this.dsPoruke;
            // 
            // dsPoruke
            // 
            this.dsPoruke.DataSetName = "dsPoruke";
            this.dsPoruke.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer6
            // 
            this.reportViewer6.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dsPorukeTabelaBindingSource;
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "cSharpIntroWinForms.IB200002.riport.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(0, 0);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.ServerReport.BearerToken = null;
            this.reportViewer6.Size = new System.Drawing.Size(800, 450);
            this.reportViewer6.TabIndex = 0;
            // 
            // frmIzvjesceIB200002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer6);
            this.Name = "frmIzvjesceIB200002";
            this.Text = "frmIzvjesceIB200002";
            this.Load += new System.EventHandler(this.frmIzvjesceIB200002_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPorukeTabelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPoruke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dsPorukeTabelaBindingSource;
        private dsPoruke dsPoruke;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
    }
}