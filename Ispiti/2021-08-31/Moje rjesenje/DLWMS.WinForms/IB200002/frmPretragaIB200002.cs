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
        string filterImePrezime;
        public frmPretragaIB200002()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmPretragaIB200002_Load(object sender, EventArgs e)
        {
            lblProsjek.Text = "0";
        }
        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Filtriraj();
        }
        private List<StudentiStatistika> Filtriraj()
        {
            var lista = new List<StudentiStatistika>();
            var student = _baza.StudentiPredmeti.Where(s => s.Student.Ime.ToLower().Contains(filterImePrezime) || s.Student.Prezime.ToLower().Contains(filterImePrezime)).Select(s => s.Student).ToList();
            for (int i = 0; i < student.Count; i++)
            {
                lista.Add(new StudentiStatistika
                {
                    Student = student[i],
                    PolozeniPredmeti =  _baza.StudentiPredmeti.ToList().Where(s=>s.Student.Id == student[i].Id).Select(s=>s.Predmet.Naziv).ToString() + ";",
                    BrojPolozenih = _baza.StudentiPredmeti.ToList().Where(s=>s.Student.Id == student[i].Id).Count(),
                    Prosjek = _baza.StudentiPredmeti.ToList().Where(s=>s.Student.Id == student[i].Id).Average(o=>o.Ocjena)
                });
            }
            if (lista.Count != 0)
                lblProsjek.Text = lista.Average(o => o.Prosjek).ToString();
            else if (lista.Count == 0)
                lblProsjek.Text = "0";
            return lista;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filterImePrezime = textBox1.Text.ToLower();
            UcitajPodatkeOStudentima();
        }

        private void Filter()
        {
            var lista = _baza.Studenti.Where(s => s.Ime.ToLower().Contains(filterImePrezime)
                    || s.Prezime.ToLower().Contains(filterImePrezime)).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = (dataGridView1.SelectedRows[0].DataBoundItem as StudentiStatistika).Student;
            if(e.ColumnIndex == 4)
            {
                var frmScan = new frmScanIspitaIB200002(student);
                frmScan.Show();
            }
        }
    }
}
