using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200002
{
    public partial class frmIzvjestajiIB200002 : Form
    {
        private List<KorisniciIspitiScan> _skeniranja;


        public frmIzvjestajiIB200002(List<KorisniciIspitiScan> skeniranja)
        {
            InitializeComponent();
            _skeniranja = skeniranja;
        }

        private void frmIzvjestajiIB200002_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();
            var tbl = new dsIzvjestaj.tblScanIspitaDataTable();
            foreach (var studenta in _skeniranja)
            {
                var red = tbl.NewtblScanIspitaRow();
                red.Napomena = studenta.Napomena;
                red.Predmet = studenta.Predmet.ToString();
                red.Varanje = studenta.Varanje == true ? "Da" : "Ne";

                tbl.AddtblScanIspitaRow(red);
            }
            rds.Name = "dsPrikaz";
            rds.Value = tbl;


            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
