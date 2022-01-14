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

namespace DLWMS.WinForms.IB200002
{
    public partial class frmCovidTestIB200002 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
       
        public frmCovidTestIB200002()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmCovidTestIB200002_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = _baza.Studenti.ToList();
            UcitajPodatke();
            
        }
        private void UcitajPodatke()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _baza.StudentiCovidTestovi.ToList();
            lblBroj.Text = _baza.StudentiCovidTestovi.Count().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidirajDatum())
            {
                var noviTest = new StudentiCovidTestovi()
                {
                    Datum = dateTimePicker1.Value,
                    Rezultat = comboBox1.Text,
                    NalazDostavljen = cbNalaz.Checked.ToString(),
                    Student = comboBox2.SelectedItem as Student,
                };
                _baza.StudentiCovidTestovi.Add(noviTest);
                _baza.SaveChanges();
                UcitajPodatke();
            }
            else
            {
                MessageBox.Show("Ne mozete dodati na isti dan dva testa!");
            }
        }

        private bool ValidirajDatum()
        {
            var odabraniStudent = comboBox2.SelectedItem as Student;
            foreach (var studenta in _baza.StudentiCovidTestovi)
            {
                if (studenta.Datum.Date == dateTimePicker1.Value.Date && studenta.Student.Id == odabraniStudent.Id)
                    return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int brojac = int.Parse(txtBrojTestova.Text);
            Random rand = new Random();
            for (int i = 0; i < brojac; i++)
            {
                var noviTest = new StudentiCovidTestovi()
                {
                    Datum = DateTime.Now,
                    Rezultat = (rand.NextDouble() > 0.5).ToString(),
                    NalazDostavljen = rand.NextDouble() > 0.5 ? "Negativan" : "Pozitivan",
                    Student = _baza.Studenti.ToList().ElementAt(rand.Next(1,5))
                };
                _baza.StudentiCovidTestovi.Add(noviTest);
                _baza.SaveChanges();
                UcitajPodatke();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?", "Obavijest", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _baza.StudentiCovidTestovi.RemoveRange(_baza.StudentiCovidTestovi);
                _baza.SaveChanges();
                UcitajPodatke();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var lista = _baza.StudentiCovidTestovi.ToList();
            var frmIzvjestaj = new frmIzvjestaji(lista);
            frmIzvjestaj.Show();
        }
    }
}
