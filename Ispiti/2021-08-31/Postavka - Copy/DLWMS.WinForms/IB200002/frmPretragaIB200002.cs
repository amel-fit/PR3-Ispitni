using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
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
    public partial class frmPretragaIB200002 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        string filterImePrezime = "";
        public frmPretragaIB200002()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }
        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Filtriraj();
        }
        private List<StudentStatistika> Filtriraj()
        {
            var listaStatistika = new List<StudentStatistika>();
            var student = _baza.StudentiPredmeti.Where(s => 
            (filterImePrezime == "" || s.Student.Ime.ToLower().Contains(filterImePrezime) || s.Student.Prezime.ToLower().Contains(filterImePrezime))).Select(s=>s.Student).Distinct().ToList();
            for (int i = 0; i < student.Count; i++)
            {
                listaStatistika.Add(new StudentStatistika
                {
                    Student = student[i],
                    Prosjek = _baza.StudentiPredmeti.ToList().Where(s=>s.Student.Id == student[i].Id).Average(o=>o.Ocjena),
                    PolozeniPredmetiStudent = string.Join(";", _baza.StudentiPredmeti.ToList().Where(s=>s.Student.Id == student[i].Id).Select(p=>p.Predmet.Naziv)),
                    BrojPolozenih = _baza.StudentiPredmeti.ToList().Where(s => s.Student.Id == student[i].Id).Select(p=>p.Predmet).Count(),
                });
            }
            if(listaStatistika.Count != 0)
            {
                lblProsjek.Text = listaStatistika.Average(o => o.Prosjek).ToString();
                var najveci = listaStatistika.OrderByDescending(o => o.Prosjek).First();
                lblImepRezime.Text = $"Najveci prosjek: {najveci.Student}";
            }
            else
            {
                lblProsjek.Text = "0";
                lblImepRezime.Text = "NOT_SET";
            }

            return listaStatistika;
        }
        private void frmPretragaIB200002_Load(object sender, EventArgs e)
        {
            filterImePrezime = textBox1.Text.ToLower();
            UcitajPodatkeOStudentima();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabrani = (dataGridView1.SelectedRows[0].DataBoundItem as StudentStatistika).Student;
            if(e.ColumnIndex == 4)
            {
                var forma = new frmScanIspitaIB200002(odabrani);
                forma.Show();
            }
        }
    }
}
