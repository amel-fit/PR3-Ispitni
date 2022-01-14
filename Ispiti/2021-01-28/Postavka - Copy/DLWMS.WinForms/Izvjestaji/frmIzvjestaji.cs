using DLWMS.WinForms.Entiteti;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<Student> _listaStudenata;


        public frmIzvjestaji(List<Student> listaStudenata)
        {
            InitializeComponent();
            _listaStudenata = listaStudenata;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();
            var tbl = new dsDLWMS.tblStudentiDataTable();
            foreach (var student in _listaStudenata)
            {
                var red = tbl.NewtblStudentiRow();
                red.RB = student.Id.ToString();
                red.Indeks = student.Indeks;
                red.Ime = student.Ime;
                red.Prezime = student.Prezime;
                red.Spol = student.Spol.ToString();
                red.Godina = student.GodinaStudija.ToString();
                red.Aktivan = student.Aktivan == true ? "Da" : "Ne";

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
