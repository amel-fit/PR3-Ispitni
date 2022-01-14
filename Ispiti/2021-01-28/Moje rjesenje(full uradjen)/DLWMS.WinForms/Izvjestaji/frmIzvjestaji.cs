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

            var tabela = new dsDLWMS.tblStudentiDataTable();
            string aktiv;
            foreach (var studenta in _listaStudenata)
            {
                var red = tabela.NewtblStudentiRow();
                red.Ime = studenta.Ime;
                red.Prezime = studenta.Prezime;
                red.RB = studenta.Id.ToString();
                if (studenta.Aktivan == true)
                    aktiv = "Da";
                else
                {
                    aktiv = "Ne";
                }
                red.Aktivan = aktiv;
                tabela.AddtblStudentiRow(red);
            }
            rds.Name = "dsStudenti";
            rds.Value = tabela;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
