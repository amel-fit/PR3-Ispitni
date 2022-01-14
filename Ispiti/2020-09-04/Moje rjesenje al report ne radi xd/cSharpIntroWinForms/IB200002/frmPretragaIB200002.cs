using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IB200002
{
    public partial class frmPretragaIB200002 : Form
    {
        KonekcijaNaBazu db = DLWMS.DB;
        public frmPretragaIB200002()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var filter = textBox1.Text.ToLower();
            var rezultat = db.KorisniciPredmeti.Where(p => p.Predmet.Naziv.ToLower().Contains(filter)).ToList();
            UcitajPodatke(rezultat);
            if (rezultat.Count() != 0)
                lblProsjek.Text = rezultat.Average(o => o.Ocjena).ToString();
            else
                lblProsjek.Text = "0";
        }

        private void UcitajPodatke(List<KorisniciPredmeti> rezultat = null)
        {
            dgvPretraga.DataSource = null;
            dgvPretraga.DataSource = rezultat ?? db.KorisniciPredmeti.ToList();
        }

        private void frmPretragaIB200002_Load(object sender, EventArgs e)
        {
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex== 4)
            {
                var korisnikPredmet = dgvPretraga.SelectedRows[0].DataBoundItem as KorisniciPredmeti;
                if (korisnikPredmet != null)
                {
                    var forma = new frmPorukeIB200002(korisnikPredmet.Korisnik);
                    forma.ShowDialog();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Sumiraj);
            var n = long.Parse(textBox2.Text);
            thread.Start(n);
        }

        private void Sumiraj(object obj)
        {
            var n = long.Parse(obj.ToString());
            long suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += i;
                Action action = () => lblSuma.Text = suma.ToString();
                BeginInvoke(action);
            }
        }
    }
}
