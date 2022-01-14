using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200002
{
    public partial class frmPotvrdeIB200002 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        public frmPotvrdeIB200002()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmPotvrdeIB200002_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _baza.StudentiPotvrde.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var brojac = int.Parse(textBox1.Text);
                var rand = new Random();
                for (int i = 0; i < brojac; i++)
                {
                    var novaPotvrda = new StudentiPotvrde()
                    {
                        Student = _baza.Studenti.ToList().ElementAt(rand.Next(1, 6)),
                        Datum = DateTime.Now,
                        Izdata = rand.NextDouble() > 0.5,
                        Svrha = $"Regulisanje stipendije_{i}"
                    };
                    _baza.StudentiPotvrde.Add(novaPotvrda);
                    _baza.SaveChanges();
                    UcitajPodatke();
                }
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(textBox1, errorProvider1, "Obavezno polje!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da zelite obrisati sve potvrde?", "Obavijest", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _baza.StudentiPotvrde.RemoveRange(_baza.StudentiPotvrde);
                _baza.SaveChanges();
                UcitajPodatke();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveCSV();
            MessageBox.Show("Uspjesno spaseni podaci!");
        }
        public static void SaveCSV()
        {
            using (StreamWriter sw = File.AppendText("Potvrde.csv"))
            {
                foreach (var potvrda in DLWMSdb.Baza.StudentiPotvrde)
                {
                    sw.WriteLine(potvrda.ID + ", " + potvrda.Datum + ", " + potvrda.Svrha + ", " + potvrda.Izdata);

                }

                sw.Close();
            }
        }
    }
}
