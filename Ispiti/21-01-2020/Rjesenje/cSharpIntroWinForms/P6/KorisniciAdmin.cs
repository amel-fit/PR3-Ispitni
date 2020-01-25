using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P11;
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
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void IzracunajProsjek(List<Korisnik> rezultati = null)
        {
            try
            {
                // Ne moraju svi korisnici imati ocjene, zato je potreban ovaj brojac
                int korisniciSaOcjenama = 0;
                double sumaOcjena = 0; // ukupna suma ocjena

                if (rezultati?.Count() > 0)
                {

                    foreach (var rr in rezultati)
                    {
                        double tempSum = 0;

                        tempSum += rr.Uspjeh.Sum(x => x.Ocjena); // sum ocjena iz svih predmeta
                        if (tempSum == 0) // ako je 0 suma nema smisla ici dalje i dijeliti 0 u sljedecoj liniji, tako da idemo continue preskacemo ovog korisnika
                            continue;

                        tempSum /= rr.Uspjeh.Count();   // podijeliti na koliko ima predmeta 
                        sumaOcjena += tempSum; // Dodaj na glavnu sumu
                        korisniciSaOcjenama++;
                    }
                }

                if (korisniciSaOcjenama > 0)
                    lblProsjek.Text = (sumaOcjena / korisniciSaOcjenama).ToString("0.##"); // prikazivanje u labelu sa provjerom da li je null na metodu (?.), i 2 decimale na kraju
                else
                    lblProsjek.Text = "0";

            } catch(Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
               

        }
        private void LoadData(List<Korisnik> korisnici = null)
        {
            try
            {
                List<Korisnik> rezultati = korisnici ?? konekcijaNaBazu.Korisnici.ToList();

                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = rezultati;


                IzracunajProsjek(rezultati);
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            string filter = txtPretraga.Text.ToLower();

            List<Korisnik> rezultat = konekcijaNaBazu.Korisnici.ToList().Where(x => x.Ime.ToLower().Contains(filter) || x.Prezime.ToLower().Contains(filter)).ToList();


            // preko foreach nacin
            //List<Korisnik> rezultat = new List<Korisnik>();
            //foreach (var korisnik in konekcijaNaBazu.Korisnici)
            //{
            //    if (korisnik.Ime.ToLower().Contains(filter) || korisnik.Prezime.ToLower().Contains(filter))
            //        rezultat.Add(korisnik);
            //}
            LoadData(rezultat);
            
        }


        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Korisnik korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;
            Form forma = null;
            if (korisnik != null)
            {
                if (e.ColumnIndex == 5)
                {
                    forma = new KorisniciPolozeniPredmeti(korisnik);
                    forma.ShowDialog();
                    LoadData();
                }
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            /* Ovo nije bilo potrebno uraditi na ispitu, ali radi testiranja
              i igranja sa kodom lakse ovako ocistiti sve ocjene */

            konekcijaNaBazu.KorisniciPredmeti.RemoveRange(konekcijaNaBazu.KorisniciPredmeti.ToList());
            LoadData();
            konekcijaNaBazu.SaveChanges();

            MessageBox.Show("Uspjesno ocisceno. Ovo nije trebalo na ispitu samo sluzi za vjezbu jer ASYNC dodaje 500 predmeta!!");
        }
    }
}
