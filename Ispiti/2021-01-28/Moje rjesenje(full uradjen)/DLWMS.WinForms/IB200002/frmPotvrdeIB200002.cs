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
        }

        private void frmPotvrdeIB200002_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void btnGenerisiPotvrde_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Morate unjeti broj");
            }
            else
            {
                int brojac = int.Parse(textBox1.Text);
                for (int i = 0; i < brojac; i++)
                {
                    Random rand = new Random();
                    var potvrda = new StudentiPotvrde()
                    {
                        Svrha = "Regulisanje stipendije",
                        Izdata = "izdata",
                        Datum = DateTime.Now,
                        Student = _baza.Studenti.ToList().ElementAt(rand.Next(1, 5)),

                    };
                    _baza.StudentiPotvrde.Add(potvrda);
                    _baza.SaveChanges();
                }
                UcitajPodatke();
            }
        }

        private void UcitajPodatke()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _baza.StudentiPotvrde.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_baza.StudentiPotvrde.Count() == 0)
            {
                MessageBox.Show("Nema potvrda!");
            }
            else if (MessageBox.Show("Jeste li sigurni?", "Obavijest", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                    _baza.StudentiPotvrde.RemoveRange(_baza.StudentiPotvrde);
                    _baza.SaveChanges();
                   UcitajPodatke();
            }
        }
        public static void SaveCSV(string poruka) 
        {
            using (StreamWriter sw = File.AppendText(poruka))
            {
                foreach (var potvrda in DLWMSdb.Baza.StudentiPotvrde)
                {
                    sw.WriteLine(potvrda.ID + "," + potvrda.Izdata + "," + potvrda.Datum);
                }
              
                sw.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SaveCSV("Potvrde.csv");
            MessageBox.Show("Spaseno");
        }
    }
}
