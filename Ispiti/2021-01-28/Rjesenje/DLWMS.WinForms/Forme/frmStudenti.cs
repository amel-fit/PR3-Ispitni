using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DLWMS.WinForms.Izvjestaji;
using DLWMS.WinForms.IBXXXXXX;

namespace DLWMS.WinForms.Forme
{
    public partial class frmStudenti : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        List<string> listaGodine = new List<string>() { "sve", "1", "2", "3" };
        List<string> listaAkitvnost = new List<string>() { "svi", "aktivan", "neaktivan"};
        List<Student> listaStudenata;
        string filterImePrezime = "";
        string filterGodina = "sve";
        int filterGodinaParsed;
        string filterAktivnost = "svi";
        bool filterAktivnostParsed;

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            ucitajComboBox();
            UcitajPodatkeOStudentima();
        }

        private void ucitajComboBox()
        {
            // Ako zelimo da se error provider ne pojavi odmah nakon ucitavanja 
            //forme moramo se unsubscirbe sa eventa (NIJE POTREBNO NA ISPITU)
            cmbAktivnost.SelectedIndexChanged -= cmbAktivnost_SelectedIndexChanged; 
            cmbGodine.SelectedIndexChanged -= cmbGodine_SelectedIndexChanged;
            cmbGodine.DataSource = listaGodine;
            cmbAktivnost.DataSource = listaAkitvnost;
            cmbAktivnost.SelectedIndexChanged += cmbAktivnost_SelectedIndexChanged;
            cmbGodine.SelectedIndexChanged += cmbGodine_SelectedIndexChanged;

        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {          
            PrikaziFormu(new frmNoviStudent());
            UcitajPodatkeOStudentima();
        }

        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            listaStudenata = _baza.Studenti.Where(x =>
            (filterImePrezime == "" || (x.Ime.ToLower().Contains(filterImePrezime) || x.Prezime.ToLower().Contains(filterImePrezime))) &&
            (filterGodina=="sve" || x.GodinaStudija == filterGodinaParsed) &&
            (filterAktivnost=="svi" || x.Aktivan == filterAktivnostParsed)
            ).ToList();
            izracunajProsjek(listaStudenata);
            lblBrojStudenata.Text = $"Broj prikazanih studenata:{listaStudenata.Count.ToString()}";
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = listaStudenata;
        }

        private void izracunajProsjek(List<Student> studenti)
        {
            double ukupniProsjek = 0;
            int brojKorisnikaSaOcjenama=0;
            foreach(var s in studenti)
            {
                if (s.StudentiPredmeti.Count > 0)
                {
                    double prosjek = s.StudentiPredmeti.Average(x => x.Ocjena);
                    if (prosjek == 0)
                        continue;
                    else
                    {
                        ukupniProsjek += prosjek;
                        brojKorisnikaSaOcjenama++;
                    }
                }
                else
                    continue;
            }
            if (ukupniProsjek > 0)
                ukupniProsjek /= brojKorisnikaSaOcjenama;
            lblProsjek.Text = $"Prosjek ocjena prikazanih studenata je {ukupniProsjek}";
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
            filterImePrezime = txtPretraga.Text.ToLower();
            validiraj();
            UcitajPodatkeOStudentima();
        }

        private bool validiraj()
        {
            if (txtPretraga.Text.Length == 0)
            {
                errorProvider1.SetError(txtPretraga, "Unos imena ili prezimena je obavezan");
                return true;
            }
            else
            {
                errorProvider1.Clear();
                return false;
            }
            

        }

        private void cmbAktivnost_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterAktivnost = cmbAktivnost.Text;
            if(filterAktivnost != "svi")
            {
                if (filterAktivnost == "aktivan")
                    filterAktivnostParsed = true;
                else
                    filterAktivnostParsed = false;
            }
            validiraj();
            UcitajPodatkeOStudentima();
        }

        private void cmbGodine_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterGodina = cmbGodine.Text;
            if (filterGodina != "sve")
                filterGodinaParsed = int.Parse(filterGodina);
            validiraj();
            UcitajPodatkeOStudentima();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var frm = new frmIzvjestaji(listaStudenata);
            frm.ShowDialog();

        }

        private void btnPotvrde_Click(object sender, EventArgs e)
        {
            var frm = new frmPotvrde();
            frm.ShowDialog();
        }
    }
}
