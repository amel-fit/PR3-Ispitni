using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;

namespace DLWMS.WinForms.IBXXXXXX
{
    public partial class frmPotvrde : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        int brojPotvrda = 0;
        Student student;
        List<Potvrda> potvrde;
        public frmPotvrde()
        {
            InitializeComponent();
            this.CenterToScreen(); // Prikaze formu na sredinii ekrana
        }

        private void frmPotvrde_Load(object sender, EventArgs e)
        {
            dgvPotvrde.AutoGenerateColumns = false;
            //Uzimamo random studenta iz baze u ovom slucaju student sa Id 1 u bazi
            student = _baza.Studenti.Find(1);
            ucitajPodatke();
        }

        private void ucitajPodatke()
        {
            dgvPotvrde.DataSource = null;
            potvrde = _baza.Potvrde.ToList();
            dgvPotvrde.DataSource = potvrde;
            lblBrojPotvrda.Text = $"Broj prikazanih potvrda: {potvrde.Count}";
            
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            if(brojPotvrda==0)
            {
                MessageBox.Show("Unesite koliko zelize potvrda generisati");
                return;
            }
            var generisiPotvrde = Task.Run(() =>
            {
                for(int i=0;i<brojPotvrda;i++)
                {
                    var potvrda = new Potvrda()
                    {
                        Student = student,
                        Datum = DateTime.Now.ToString(),
                        Izdata = true,
                        Svrha = "Stipendija"
                    };
                    _baza.Potvrde.Add(potvrda);
                }
                _baza.SaveChanges();
            });
            var awaiter = generisiPotvrde.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                MessageBox.Show("Uspjesno dodane potvrde");
                ucitajPodatke();
            });
        }

        private void txtBrojPotvrda_TextChanged(object sender, EventArgs e)
        {
            if(txtBrojPotvrda.TextLength>0)
            {
                if(Regex.IsMatch(txtBrojPotvrda.Text, @"^\d+$"))// preovjerava da li je unos broj
                {
                    brojPotvrda = int.Parse(txtBrojPotvrda.Text);
                }
                else
                {
                    MessageBox.Show("Dozvoljeni su samo brojevi");
                    txtBrojPotvrda.Text = "";
                    brojPotvrda = 0;
                }
            }
            else
            {
                brojPotvrda = 0;
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if(potvrde.Count==0)
            {
                MessageBox.Show("Nema potvrda za izbrisat");
                return;
            }
            //kreira formu na lokaciji gdje se nalazi kursor
            var frm = new frmPotvrdiBrisanje();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var izbrisiPotvrde = Task.Run(() =>
                {
                    _baza.Potvrde.RemoveRange(_baza.Potvrde);// RemoveRange brise sve elemente prosljedjenog DB seta
                    _baza.SaveChanges();
                });
                var awaiter = izbrisiPotvrde.GetAwaiter();
                awaiter.OnCompleted(() =>
                {
                    MessageBox.Show("Uspjesno izbrisane potvrde");
                    ucitajPodatke();
                });
            }
            else
                return;
        }
    }
}
