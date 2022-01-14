using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
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
        List<Student> listaStudenata;
        string filterImePrezime = "";
        string filterGodinaStudija = "Sve";
        string filterAktivnost = "Svi";
        int filterGodinaStudijaParsed;
        bool filterAktivnostParsed;

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            errorProvider1.Clear();
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {          
            PrikaziFormu(new frmNoviStudent());
            UcitajPodatkeOStudentima();
        }
        private List<Student> Filtriraj()
        {
                 listaStudenata = _baza.Studenti.Where(s =>
               (filterImePrezime == "" || s.Ime.ToLower().Contains(filterImePrezime) || s.Prezime.ToLower().Contains(filterImePrezime)) &&
               (filterGodinaStudija == "Sve" || s.GodinaStudija == filterGodinaStudijaParsed) &&
               (filterAktivnost == "Svi" || s.Aktivan == filterAktivnostParsed)).ToList();

            if(listaStudenata.Count != 0)
            {
                lblBrojStudenata.Text = $"Broj studenata: {listaStudenata.Count()}";
                var studentSaOcjenom = listaStudenata.Where(s => s.StudentiPredmeti.Count() > 0).ToList();
                var prosjecna = studentSaOcjenom.Average(s =>(double?) s.StudentiPredmeti.Average(o => o.Ocjena));
                lblProsjecna.Text = $"Prosjecna ocjena: {prosjecna}";
            }
            else
            {
                lblBrojStudenata.Text = $"Trenutno nema studenata u listi!";
            }
                return listaStudenata;
            
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
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            if (Validiraj())
                filterImePrezime = txtPretraga.Text.ToLower();
           UcitajPodatkeOStudentima();
           
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtPretraga, errorProvider1, "Obavezno polje!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                filterGodinaStudija = comboBox1.SelectedItem.ToString();
                if (filterGodinaStudija != "Sve")
                {
                    filterGodinaStudijaParsed = int.Parse(comboBox1.SelectedItem.ToString());
                }
            }
                UcitajPodatkeOStudentima();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                filterAktivnost = comboBox2.SelectedItem.ToString();
                if (filterAktivnost != "Svi")
                {
                    if (filterAktivnost == "Aktivni")
                        filterAktivnostParsed = true;
                    else
                        filterAktivnostParsed = false;
                }
            }
                UcitajPodatkeOStudentima();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmIzvj = new frmIzvjestaji(listaStudenata);
            frmIzvj.Show();
        }
    }
}
