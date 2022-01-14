using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IB200002
{
    public partial class frmPorukeIB200002 : Form
    {
        private Korisnik _korisnik;
        KonekcijaNaBazu db = DLWMS.DB;

        public frmPorukeIB200002(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private void frmPorukeIB200002_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            lblImePrezime.Text = _korisnik.Ime + " " + _korisnik.Prezime;
            UcitajPoruke();
        }

        private void UcitajPoruke()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.KorisniciPoruke.Where(k => k.Korisnik.Id == _korisnik.Id).ToList();
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            var frmNova = new frmNovaPorukaIB200002(_korisnik);
            if(frmNova.ShowDialog() == DialogResult.OK)
            {
                UcitajPoruke();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                var poruka = dataGridView1.SelectedRows[0].DataBoundItem as KorisniciPoruke;
                if (MessageBox.Show("Jeste li sigurni?", "Obavijest", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.KorisniciPoruke.Remove(poruka);
                    db.SaveChanges();
                    UcitajPoruke();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var poruke = db.KorisniciPoruke.Where(k => k.Korisnik.Id == _korisnik.Id).ToList();
            var dtoObjekat = new dtoKorisnik();
            dtoObjekat.ImePrezime = _korisnik.Ime;
            dtoObjekat.ListaPoruka = poruke;
            var frmIzvjestaj = new frmIzvjesceIB200002(dtoObjekat);
            frmIzvjestaj.ShowDialog();
        }
    }
}
