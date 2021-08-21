using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.IB180207;
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
        List<Student> filtrianiStudenti;
        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
            izracunajProsjek(_baza.Studenti.ToList());
            lblBrojStudenata.Text = dgvStudenti.Rows.Count.ToString();
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

        private void filtirajListu()
        {
            if (validiraj())
            {

                var datumOD = dtpOD.Value;
                var datumDO = dtpDO.Value;

                var studenti = _baza.Studenti.ToList();
                string operat = cmbOperator.SelectedItem.ToString();
                int ocjena = int.Parse(cmbOcjena.SelectedItem.ToString());

                var filterPoDatumu = _baza.StudentiPredmeti.Where(x => x.Datum >= datumOD && x.Datum <= datumDO).ToList();

                var filterPoOcjeniIDatumu = filtirajPoOcjeni(filterPoDatumu, operat, ocjena);

                var studentIDs = filterPoOcjeniIDatumu.Select(x => x.Student.Id).ToList();

                filtrianiStudenti = _baza.Studenti.Where(x => studentIDs.Contains(x.Id)).ToList();

                ucitajPodatke(filtrianiStudenti);

            }
        }

        private void ucitajPodatke(List<Student> filtriraniStudenti)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = filtriraniStudenti;
            izracunajProsjek(filtrianiStudenti);
            lblBrojStudenata.Text = filtriraniStudenti.Count.ToString();
        }

        private void izracunajProsjek(List<Student> filtrianiStudenti)
        {
            double ukupanProsjek = 0;
            int brojac = 0;

            foreach (var s in filtrianiStudenti)
            {
                if (s.StudentiPredmeti.Count > 0)
                {
                    var prosjek = s.StudentiPredmeti.Average(x => x.Ocjena);
                    if (prosjek == 0) continue;
                    brojac++;
                    ukupanProsjek += prosjek;
                }
                else continue;

            }
            if (ukupanProsjek > 0)
                ukupanProsjek /= brojac;
            lblProsjecnaOcjena.Text = ukupanProsjek.ToString();
        }

        private List<StudentiPredmeti> filtirajPoOcjeni(List<StudentiPredmeti> filterPoDatumu, string operat, int ocjena)
        {
            switch (operat)
            {
                case "=":
                    filterPoDatumu = filterPoDatumu.Where(x => x.Ocjena == ocjena).ToList();
                    break;
                case ">":
                    filterPoDatumu = filterPoDatumu.Where(x => x.Ocjena > ocjena).ToList();
                    break;
                case ">=":
                    filterPoDatumu = filterPoDatumu.Where(x => x.Ocjena >= ocjena).ToList();
                    break;
                case "<":
                    filterPoDatumu = filterPoDatumu.Where(x => x.Ocjena < ocjena).ToList();
                    break;
                case "<=":
                    filterPoDatumu = filterPoDatumu.Where(x => x.Ocjena <= ocjena).ToList();
                    break;
            }
            return filterPoDatumu;
        }

        private bool validiraj()
        {
            return Validator.ValidirajKontrolu(cmbOperator, errorProvider1, "Obavezan operator!") &&
                Validator.ValidirajKontrolu(cmbOcjena, errorProvider1, "Obavezna ocjena");
        }

        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtirajListu();
        }

        private void cmbOcjena_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtirajListu();
        }

        private void btnCovid_Click(object sender, EventArgs e)
        {
            frmCovidTestIB180207 frmCovidTestIB180207 = new frmCovidTestIB180207();
            frmCovidTestIB180207.ShowDialog();
        }
    }
}
