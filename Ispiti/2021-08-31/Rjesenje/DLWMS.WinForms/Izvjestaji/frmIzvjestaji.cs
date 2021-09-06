using DLWMS.WinForms.BrojIndeksa;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<StudentiIspitiScan> skenovi;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(List<StudentiIspitiScan> skenovi) : this()
        {
            this.skenovi = skenovi;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();

            var tblSken = new dsDLWMS.SkenDataTable();
            for (int i = 0; i < skenovi.Count; i++)
            {
                var red = tblSken.NewSkenRow();
                red.Predmet = skenovi[i].Predmet.ToString();
                red.Napomena = skenovi[i].Napomena;
                red.Varanje = skenovi[i].Varanje == true ? "Da" : "Ne";
                tblSken.Rows.Add(red);
            }

            rds.Name = "dsSken";
            rds.Value = tblSken;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
