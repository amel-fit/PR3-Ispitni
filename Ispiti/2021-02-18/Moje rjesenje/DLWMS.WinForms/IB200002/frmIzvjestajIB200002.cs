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
    public partial class frmIzvjestajIB200002 : Form
    {
        private List<StudentiCovidTestovi> lista;


        public frmIzvjestajIB200002(List<StudentiCovidTestovi> lista)
        {
            this.lista = lista;
            InitializeComponent();
        }

        private void frmIzvjestajIB200002_Load(object sender, EventArgs e)
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

            rds.Name = "dsCovid";
            rds.Value = tbl;
           

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
