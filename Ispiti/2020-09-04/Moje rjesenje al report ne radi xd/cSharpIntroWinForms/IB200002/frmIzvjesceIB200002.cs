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

namespace cSharpIntroWinForms.IB200002
{
    public partial class frmIzvjesceIB200002 : Form
    {
        private dtoKorisnik _dtoObjekat;

       
        public frmIzvjesceIB200002(dtoKorisnik dtoObjekat)
        {
            InitializeComponent();
            _dtoObjekat = dtoObjekat;
        }

        private void frmIzvjesceIB200002_Load(object sender, EventArgs e)
        {

            var tabela = new dsPoruke.dsPorukeTabelaDataTable();
            foreach (var poruka in _dtoObjekat.ListaPoruka)
            {
                var noviRed = tabela.NewdsPorukeTabelaRow();
                noviRed.ID = poruka.ID.ToString();
                noviRed.Datum = poruka.Datum.ToString();
                noviRed.Poruka = poruka.Poruka;

                tabela.Rows.Add(noviRed);
            }


            var izvorPodataka = new ReportDataSource();
            izvorPodataka.Name = "DataSet1";
            izvorPodataka.Value = tabela;
            reportViewer6.LocalReport.DataSources.Add(izvorPodataka);

            this.reportViewer6.RefreshReport();
            this.reportViewer6.RefreshReport();
        }
    }
}
