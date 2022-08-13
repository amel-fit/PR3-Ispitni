using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.DB;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinForms.IspitBrojIndeksa
{
    public partial class frmIzvjestajKonsultacija : Form
    {
        Student _student;
        List<StudentKonsultacija> _konsultacije;
        public frmIzvjestajKonsultacija(Student student, List<StudentKonsultacija> konsultacije)
        {
            InitializeComponent();
            _student = student;
            _konsultacije = konsultacije;
        }

        private void frmIzvjestajKonsultacija_Load(object sender, EventArgs e)
        {
            if (_konsultacije != null && _student != null)
            {
                ReportParameterCollection rpc = new ReportParameterCollection();
                ReportParameter rp1 = new ReportParameter("student", _student.ToString());
                ReportParameter rp2 = new ReportParameter("brojKonsultacija", _konsultacije.Count().ToString());
                rpc.Add(rp1);
                rpc.Add(rp2);
                var tblKonsultacije = new dsKonsultacije.tblKonsultacijeDataTable();
                foreach (var k in _konsultacije)
                {
                    var red = tblKonsultacije.NewtblKonsultacijeRow();
                    red.Rb = k.Id.ToString();
                    red.Predmet = k.Predmet.ToString();
                    red.Vrijeme = k.VrijemeOdrzavanja.ToString();
                    red.Napomena = k.Napomena.ToString();
                    tblKonsultacije.AddtblKonsultacijeRow(red);
                }
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsStudentKonsultacije";
                rds.Value = tblKonsultacije;
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.SetParameters(rpc);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
