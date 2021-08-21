using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB180207
{
    public partial class frmCovidTestIB180207 : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        int brojTestova;
        public frmCovidTestIB180207()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmCovidTestIB180207_Load(object sender, EventArgs e)
        {
            try
            {
                ucitajPodatke();
                ucitajStudenteComboBox();
                ucitajRezultatComboBox();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
           
        }

        private void ucitajRezultatComboBox()
        {
            cmbRezultatTesta.Items.Add("Negativan");
            cmbRezultatTesta.Items.Add("Pozitivan");
            cmbRezultatTesta.SelectedItem = cmbRezultatTesta.Items[0];
        }

        private void ucitajStudenteComboBox()
        {
            cmbStudent.Items.AddRange(_db.Studenti.ToArray());
            cmbStudent.SelectedItem = cmbStudent.Items[0];
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (provjeriDatum())
            {

                var studentCovid = new StudentiCovidTestovi()
                {
                    Student = cmbStudent.SelectedItem as Student,
                    DatumVrijeme = dtmDatumTestiranja.Value,
                    Rezultat = cmbRezultatTesta.SelectedItem.ToString(),
                    NalazDostavljen = cbNalaz.Checked
                };
                _db.StudentiCovidTestovi.Add(studentCovid);
                _db.SaveChanges();
                ucitajPodatke();
            }
            else MessageBox.Show("Vec je unesen Student sa tim datumom", "Warning");
        }

        private bool provjeriDatum()
        {
            var selStudent = cmbStudent.SelectedItem as Student;
            foreach (var s in _db.StudentiCovidTestovi)
            {
                if (s.DatumVrijeme.Date == dtmDatumTestiranja.Value.Date && s.Student.Id == selStudent.Id)
                    return false;

            }
            return true;
        }

        private void ucitajPodatke()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _db.StudentiCovidTestovi.ToList();
            lblBrojTestova.Text = _db.StudentiCovidTestovi.Count().ToString();
        }

        private void txtBrojTestova_TextChanged(object sender, EventArgs e)
        {
            int intParse;
            if(!int.TryParse(txtBrojTestova.Text, out intParse))
            {
                txtBrojTestova.Text = "";
            }
            brojTestova = int.Parse(txtBrojTestova.Text);
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            Action action = () => ucitajPodatke();
            await Task.Run(() =>
            {

                for (int i = 1; i <= brojTestova; i++)
                {
                    Random rand = new Random();
                    Random rand2 = new Random();
                    var range = rand.Next(1, _db.Studenti.Count());

                    var randomStudent = new StudentiCovidTestovi()
                    {
                        DatumVrijeme = DateTime.Now,
                        NalazDostavljen = rand.NextDouble() > 0.5,
                        Rezultat = rand2.NextDouble() > 0.5 ? "Negativan" : "Pozitivan",
                        Student = _db.Studenti.ToList().ElementAt(range)
                    };
                    _db.StudentiCovidTestovi.Add(randomStudent);
                }
            });
            _db.SaveChanges();
            BeginInvoke(action);
            MessageBox.Show($"Uspjesno generisano {brojTestova} rezultata COVID testiranja.");
        }

        private void btnObrisiTestove_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Da li ste sigurni da želite obrisati sve podatke o COVID testovima ? ","Warning",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _db.StudentiCovidTestovi.RemoveRange(_db.StudentiCovidTestovi);
                _db.SaveChanges();
                ucitajPodatke();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            frmIzvjestaji frm = new frmIzvjestaji(_db.StudentiCovidTestovi.ToList());
            frm.ShowDialog();
        }
    }
}
