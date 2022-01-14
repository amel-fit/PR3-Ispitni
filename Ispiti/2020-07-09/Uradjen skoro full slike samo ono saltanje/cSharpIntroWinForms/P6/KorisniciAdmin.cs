using cSharpIntroWinForms.IB200002;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P8;
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

namespace cSharpIntroWinForms
{
    public partial class KorisniciAdmin : Form
    {
        KonekcijaNaBazu _baza = DLWMS.DB;
        string filterImePrezime = "";
        string filterSpol = "Svi";
        List<Korisnik> lista;
        bool filteradministrator;

        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
            txtPretraga.Select();
        }

        private void LoadData(List<Korisnik> korisnici = null)
        {
            try
            {
                 lista = _baza.Korisnici.Where(k => (filterImePrezime == "" || k.Ime.ToLower().Contains(filterImePrezime) || k.Prezime.ToLower().Contains(filterImePrezime)) &&
                (filterSpol == "Svi" || k.Spol.Naziv.ToLower() == filterSpol.ToLower()) &&
                (filteradministrator == k.Admin)).ToList();
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabrani = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            if(e.ColumnIndex == 5)
            {
                var frm = new KorisnikSlikePregled(odabrani);
                frm.Show();
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            filterImePrezime = txtPretraga.Text.ToLower();
            LoadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterSpol = comboBox1.Text.ToString();
            LoadData();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                filteradministrator = true;
            else
            filteradministrator = false;
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmIzvj = new frmIzvjestajIB200002(lista);
            frmIzvj.Show();
        }
        async void Sumiraj()
        {
            var suma = 0;
            await Task.Run(() => {
                for (int i = 0; i <= int.Parse(textBox1.Text); i++)
                    suma += i;
            });
            Action akcija = () => label17.Text = suma.ToString();
            BeginInvoke(akcija);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Sumiraj();
           
        }
    }
}
