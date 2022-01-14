using cSharpIntroWinForms.P8;
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
    public partial class frmIzvjestajIB200002 : Form
    {
        private List<Korisnik> _lista;

        public frmIzvjestajIB200002(List<Korisnik> lista)
        {
            _lista = lista;
            InitializeComponent();
        }

        private void frmIzvjestajIB200002_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();

            var tbl = new dsPolozeni.tblPolozeniDataTable();
            foreach (var studenta in _lista)
            {// u rjesenju on je ispisao samo studente xd, ovo je pokusaj izvjestaj vrati samo putanje do toga
                var red = tbl.NewtblPolozeniRow();
                red.DatumPolaganja = studenta.Polozeni.Select(d => d.DatumPolaganja).ToString();
                red.Ocjena = studenta.Polozeni.Select(o => o.Ocjena.ToString()).ToString();
                red.Predmet = studenta.Polozeni.Select(p => p.Predmet).ToString();

                tbl.AddtblPolozeniRow(red);
                
            }
            rds.Name = "dsPolozeni";
            rds.Value = tbl;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
