using cSharpIntroWinForms.IB190073;
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

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
            UcitajSpolove();
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
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici ?? konekcijaNaBazu.Korisnici.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }


        /// <summary>
        /// 1.Zadatak
        /// </summary>
        /// ---------------------
        private void UcitajSpolove()
        {
            cmbSpol.DataSource = konekcijaNaBazu.Spolovi.ToList();
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.ValueMember = "Id";
        }
        private void PretragaPoImenuPrezimenu()
        {
            var rezultat = konekcijaNaBazu.Korisnici.Where(x => x.Ime.ToLower().Contains(txtPretraga.Text.ToLower()) || x.Prezime.ToLower().Contains(txtPretraga.Text.ToLower())).ToList();
            LoadData(rezultat);
        }
        private void PretragaPoSpoluIAdminu()
        {
            var odabraniSpol = cmbSpol.SelectedItem as Spolovi;
            var rezultat = konekcijaNaBazu.Korisnici.Where(x => x.Spol.Id == odabraniSpol.Id  && x.Admin == cbAdministrator.Checked).ToList();
            LoadData(rezultat);
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            if (txtPretraga.Text == "")
                PretragaPoSpoluIAdminu();
            else
                PretragaPoImenuPrezimenu();
        }
        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            //prvo izdvojiti odabrani spol jer iz nekog razloga ne prepoznaje kada se u LINQ postavi 
            var odabraniSpol = cmbSpol.SelectedItem as Spolovi;
            var rezultat = konekcijaNaBazu.Korisnici.Where(x => x.Spol.Id == odabraniSpol.Id).ToList();
            LoadData(rezultat);
        }
        private void cbAdministrator_CheckedChanged(object sender, EventArgs e)
        {
            var rezultat = konekcijaNaBazu.Korisnici.Where(x => x.Admin == cbAdministrator.Checked).ToList();
            LoadData(rezultat);
        }
        //----------------------








        /// <summary>
        /// 2. Zadatak Izvjestaj
        /// </summary>
        //----------------------
        private void btnPrintajPolozene_Click(object sender, EventArgs e)
        {
            dtoKorisnik objekat = new dtoKorisnik();
            objekat.ListaKorisnika = dgvKorisnici.DataSource as List<Korisnik>;
            frmIzvjestaj izvjestaj = new frmIzvjestaj(objekat);
            izvjestaj.Show();
        }
        //----------------------











        //3.Zadatak Slike
        //----------------------
        private void btnSlike_Click(object sender, EventArgs e)
        {
            var odabrani = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            frmKorisniciSlikePregled slike = new frmKorisniciSlikePregled(odabrani);
            slike.ShowDialog();
        }
        //----------------------












        //5.Zadatak Thread sumiranje
        //----------------------
        async void MetodaSumiranja()
        {
            await Task.Run(()=> {
                var suma = 0;
                for (int i = 0; i <= int.Parse(txtThreadInput.Text); i++)
                    suma += i;
                lblSuma.Text = suma.ToString();
            });
        }

        private void btnThreadSuma_Click(object sender, EventArgs e)
        {
            MetodaSumiranja();
        }
        //----------------------

    }
}
