using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.IB200002;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmStudenti : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        string znakFilter;
        int ocjenaFilter;

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
            errorProvider1.Clear();
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {          
            PrikaziFormu(new frmNoviStudent());
            UcitajPodatkeOStudentima();
        }

        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = Filtriraj();
        }

        private void PrikaziFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            Form form = null;
            if (student != null)
            {
                if (e.ColumnIndex == 6) 
                    form = new frmStudentiPredmeti(student);
                else
                    form = new frmNoviStudent(student);
                PrikaziFormu(form);

                UcitajPodatkeOStudentima();
            }
        }
        private List<Student> Filtriraj()
        {
                var datumOd = dateTimePicker1.Value.Date;
                var datumDo = dateTimePicker2.Value.Date;
                var lista = _baza.StudentiPredmeti.Where(p => p.Datum > datumOd && p.Datum < datumDo).Select(s => s.Student).Distinct().ToList();
           
                switch (znakFilter)
                {
                    case ">":
                        lista = _baza.StudentiPredmeti.Where(p => p.Ocjena > ocjenaFilter).Select(s => s.Student).Distinct().ToList();
                        break;
                    case "<":
                        lista = _baza.StudentiPredmeti.Where(p => p.Ocjena < ocjenaFilter).Select(s => s.Student).Distinct().ToList();
                        break;
                    case "=":
                        lista = _baza.StudentiPredmeti.Where(p => p.Ocjena == ocjenaFilter).Select(s => s.Student).Distinct().ToList();
                        break;

            }
                return lista;
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(comboBox1, errorProvider1, "Obavezno polje!") &&
                 Validator.ValidirajKontrolu(comboBox2, errorProvider1, "Obavezno polje!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                znakFilter = comboBox1.SelectedItem.ToString();
                UcitajPodatkeOStudentima();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                ocjenaFilter = int.Parse(comboBox2.SelectedItem.ToString());
                UcitajPodatkeOStudentima();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmC = new frmCovidTestIB200002();
            frmC.Show();
        }
    }
}
