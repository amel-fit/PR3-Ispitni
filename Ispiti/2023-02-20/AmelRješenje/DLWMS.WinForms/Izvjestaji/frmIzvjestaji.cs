using DLWMS.Data;
using DLWMS.Data.IB230046;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {Student student { get;set;}
        List<dtoStudentiPorukeIB230046> lstPoruke { get;set;}
        
        public frmIzvjestaji(Student s, List<dtoStudentiPorukeIB230046> poruke)
        {
            InitializeComponent();
            student = s;
            lstPoruke = poruke;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var parameters = new ReportParameterCollection();

            parameters.Add(new ReportParameter("pImeStudenta", $"{student.Ime} {student.Prezime}"));
            parameters.Add(new ReportParameter("pBrojPoruka", lstPoruke.Count().ToString()));
            parameters.Add(new ReportParameter("pProsjekZnakova", GetProsjekZnakova(lstPoruke).ToString()));

            var tblPoruke = new IB230046.DataSet1.PorukeDataTable();
            for (int i = 0; i < lstPoruke.Count; i++)
            {
                var red = tblPoruke.NewPorukeRow();

                red.Rb = (i + 1).ToString();
                red.Predmet = lstPoruke.ElementAt(i).NazivPredmeta;
                red.Poruka = lstPoruke.ElementAt(i).Sadrzaj;
                red.BrojZnakova = lstPoruke.ElementAt(i).Sadrzaj.Length.ToString();
                red.Validnost = lstPoruke.ElementAt(i).Validnost.ToString();
                
                tblPoruke.AddPorukeRow(red);
            }
            var dsPoruke = new ReportDataSource();
            dsPoruke.Name = "dsPoruke";
            dsPoruke.Value = tblPoruke;
                

            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.LocalReport.DataSources.Add(dsPoruke);
            reportViewer1.RefreshReport();
        }

        private int GetProsjekZnakova(List<dtoStudentiPorukeIB230046> lstPoruke)
        {
            int zbirZnakova = 0;
            foreach (var dtoPoruka in lstPoruke)
            {
                zbirZnakova += dtoPoruka.Sadrzaj.Length;
            }
            try
            {
                return zbirZnakova / lstPoruke.Count();
            }
            catch (Exception ex) { return 0; }
        }
    }
}
