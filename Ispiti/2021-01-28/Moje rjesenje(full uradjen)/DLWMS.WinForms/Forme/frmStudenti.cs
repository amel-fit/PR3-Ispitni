using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.IB200002;
using DLWMS.WinForms.Izvjestaji;
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
        string filterImePrezime = "";
        string filterGodinaStudija = "Svi";
        int filterGodinaStudijaParsed;
        string filterAktivnost = "Svi";
        bool filterAktivnostParse;
        List<Student> listaStudenata = null;
        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {          
            PrikaziFormu(new frmNoviStudent());
            UcitajPodatkeOStudentima();
        }

        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            var lista = _baza.Studenti.Where(s => (filterImePrezime == "" || s.Ime.ToLower().Contains(txtPretraga.Text.ToLower())
                    || s.Prezime.ToLower().Contains(txtPretraga.Text.ToLower())) &&
                    (filterGodinaStudija == "Svi" || s.GodinaStudija == filterGodinaStudijaParsed) &&
                    (filterAktivnost == "Svi" || s.Aktivan == filterAktivnostParse)).ToList();

            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = lista ?? _baza.Studenti.ToList();
            listaStudenata = lista;
            lblBrojStudenata.Text = lista.Count.ToString();
            ProsjecnaOcjena(lista);
        }

        private void ProsjecnaOcjena(List<Student> studenti)
        {
            var studentiSaOcjenama = studenti.Where(student => student.StudentiPredmeti.Count > 0);
            var prosjek = studentiSaOcjenama.Average(p => (double?)p.StudentiPredmeti.Average(o => o.Ocjena));
            lblProsjecna.Text = prosjek.ToString();
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
        private bool PretragaStudenata(Student s)
        {
            return s.Ime.ToLower().Contains(txtPretraga.Text.ToLower())
                    || s.Prezime.ToLower().Contains(txtPretraga.Text.ToLower());
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                filterImePrezime = txtPretraga.Text.ToLower();
                UcitajPodatkeOStudentima();
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtPretraga, err, "Obavezno");
        }

        private void cmbGodinaStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                filterGodinaStudija = cmbGodinaStudija.Text;
                if (filterGodinaStudija != "Svi")
                {
                    filterGodinaStudijaParsed = int.Parse(filterGodinaStudija);
                }
                UcitajPodatkeOStudentima();
            }
        }

        private void cmbAktivnost_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                filterAktivnost = cmbAktivnost.Text;
                if (filterAktivnost != "Svi")
                {
                    if (filterAktivnost == "Aktivan")
                    {
                        filterAktivnostParse = true;
                    }
                    else
                        filterAktivnostParse = false;
                }
                UcitajPodatkeOStudentima();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmIzvj = new frmIzvjestaji(listaStudenata);
            frmIzvj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmPotvrde = new frmPotvrdeIB200002();
            frmPotvrde.Show();
        }
    }
}
