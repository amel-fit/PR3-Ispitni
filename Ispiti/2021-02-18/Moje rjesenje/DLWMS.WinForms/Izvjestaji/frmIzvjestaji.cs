using DLWMS.WinForms.IB200002;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<StudentiCovidTestovi> lista;

        public frmIzvjestaji(List<StudentiCovidTestovi> lista)
        {
            InitializeComponent();
            this.lista = lista;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();

            var tbl = new dsCovid.tblStudentiDataTable();

            foreach (var s in lista)
            {
                var red = tbl.NewtblStudentiRow();
                red.Datum = s.Datum.ToString();
                red.Rezultat = s.Rezultat;
                red.NalazDostavljen = s.NalazDostavljen;
                red.Student = s.Student.ToString();

                tbl.AddtblStudentiRow(red);
            }

            rds.Name = "dsDLWMS";
            rds.Value = tbl;


            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
