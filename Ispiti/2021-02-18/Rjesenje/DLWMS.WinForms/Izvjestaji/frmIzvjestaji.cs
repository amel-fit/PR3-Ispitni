using DLWMS.WinForms.IB180207;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<StudentiCovidTestovi> studentiCovidTestovis;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(List<StudentiCovidTestovi> studentiCovidTestovis):this()
        {
            this.studentiCovidTestovis = studentiCovidTestovis;
        }

        private void frmIzvjestaji_Load(object sender, System.EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();

            var tblStudenti = new dsDLWMS.StudentiCovidTestoviDataTable();
            int brojac = 1;

            foreach (var s in studentiCovidTestovis)
            {
                var red = tblStudenti.NewStudentiCovidTestoviRow();
                red.RB = brojac++;
                red.Student = s.Student.ToString();
                red.Datum = s.DatumVrijeme.ToString();
                red.Rezultat = s.Rezultat;
                red.NalazDostavljen = s.NalazDostavljen ? "Da":"Ne";
                tblStudenti.AddStudentiCovidTestoviRow(red);
            }
            rds.Name = "dsDLWMS";
            rds.Value = tblStudenti;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
