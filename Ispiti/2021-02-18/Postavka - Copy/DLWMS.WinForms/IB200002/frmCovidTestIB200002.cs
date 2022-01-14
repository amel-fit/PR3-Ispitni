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
            UcitajPodatke();
            comboBox1.DataSource = _baza.Studenti.ToList();
        }

        private void UcitajPodatke()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _baza.StudentiCovidTestovi.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidirajDatum())
            {
                var noviTest = new StudentiCovidTestovi()
                {
                    Student = comboBox1.SelectedItem as Student,
                    Datum = dateTimePicker1.Value,
                    Rezultat = comboBox2.SelectedItem.ToString(),
                    NalazDostavljen = checkBox1.Checked,
                };
                _baza.StudentiCovidTestovi.Add(noviTest);
                _baza.SaveChanges();
                UcitajPodatke();
            }
        }

        private bool ValidirajDatum()
        {
            var odabraniStudent = comboBox1.SelectedItem as Student;
            foreach (var studenta in _baza.StudentiCovidTestovi.ToList())
            {
                if (studenta.Datum.Date == dateTimePicker1.Value.Date && studenta.Student.Id == odabraniStudent.Id)
                    return false;
            }
                    return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?", "Obavijest", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _baza.StudentiCovidTestovi.RemoveRange(_baza.StudentiCovidTestovi);
                _baza.SaveChanges();
                UcitajPodatke();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var lista = _baza.StudentiCovidTestovi.ToList();
            var frm = new frmIzvjestaji(lista);
            frm.Show();
        }
    }
}
