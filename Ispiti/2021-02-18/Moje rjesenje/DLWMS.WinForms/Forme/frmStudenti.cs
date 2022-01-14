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
        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
            lblBrojStudenata.Text = "0";
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {          
            PrikaziFormu(new frmNoviStudent());
            UcitajPodatkeOStudentima();
        }

        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti ?? _baza.Studenti.ToList();
        }
        private void FiltrirajListu()
        {
            if(Validiraj()){
                var datumOd = dateTimePicker1.Value;
                var datumDo = dateTimePicker2.Value;
                string znak = cmbZnak.Text;
                int ocjena = int.Parse(cmbOcjena.SelectedItem.ToString());

                var filtrirajPoDatumu = _baza.StudentiPredmeti.Where(p => p.Datum >= datumOd && p.Datum <= datumDo).ToList();
                var filterPoOcjenaDatum = filterOcjenaDatum(filtrirajPoDatumu, znak, ocjena);

                var studentovID = filterPoOcjenaDatum.Select(s => s.Student.Id).ToList();

                var lista = _baza.Studenti.Where(s => studentovID.Contains(s.Id)).ToList();
                lblBrojStudenata.Text = lista.Count.ToString();
                if(filterPoOcjenaDatum.Select(o=>o.Ocjena).Count() !=0)
                lblProsjek.Text = filterPoOcjenaDatum.Average(o => o.Ocjena).ToString();
                UcitajPodatkeOStudentima(lista);
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(cmbOcjena, errorProvider1, "Obavezno polje!!!") &&
                Validator.ValidirajKontrolu(cmbZnak, errorProvider1, "Obavezno polje!!!");
        }

        private List<StudentiPredmeti> filterOcjenaDatum(List<StudentiPredmeti> filtrirajPoDatumu, string znak, int ocjena)
        {
            switch (znak)
            {
                case "<":
                    filtrirajPoDatumu = filtrirajPoDatumu.Where(o => o.Ocjena < ocjena).ToList();
                    break;
                case "<=":
                    filtrirajPoDatumu = filtrirajPoDatumu.Where(o => o.Ocjena <= ocjena).ToList();
                    break;
                case ">":
                    filtrirajPoDatumu = filtrirajPoDatumu.Where(o => o.Ocjena > ocjena).ToList();
                    break;
                case ">=":
                    filtrirajPoDatumu = filtrirajPoDatumu.Where(o => o.Ocjena >= ocjena).ToList();
                    break;
                case "==":
                    filtrirajPoDatumu = filtrirajPoDatumu.Where(o => o.Ocjena == ocjena).ToList();
                    break;
            }
            return filtrirajPoDatumu;
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


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

      

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrirajListu();
        }

        private void cmbOcjena_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrirajListu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmCovid = new frmCovidTestIB200002();
            frmCovid.Show();
        }
    }
}
