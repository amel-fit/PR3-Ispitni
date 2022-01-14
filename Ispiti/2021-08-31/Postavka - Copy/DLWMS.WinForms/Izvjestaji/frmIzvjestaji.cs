using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.IB200002;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<KorisniciIspitiScan> lista;

       
        public frmIzvjestaji(List<KorisniciIspitiScan> lista)
        {
            InitializeComponent();
            this.lista = lista;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();
            var tbl = new dsDLWMS.tblPredmetiDataTable();
            for (int i = 0; i < lista.Count; i++)
            {
                var red = tbl.NewtblPredmetiRow();
                red.Napomena = lista[i].Napomena;
                red.Predmet = lista[i].Varanje.ToString();
                tbl.AddtblPredmetiRow(red);
            }
            rds.Name = "dsDLWMS";
            rds.Value = tbl;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
