using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P11;
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

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
        private Korisnik korisnik;

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        public KorisniciPolozeniPredmeti(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
            UcitajOcjene();
            UcitajPolozenePredmete();

        }

        private void UcitajPredmete(List<Predmeti> rezultat = null)
        {
            try
            {
                if (rezultat != null)
                {
                    cmbPredmeti.DataSource = rezultat;

                }
                else
                {
                    cmbPredmeti.DataSource = konekcijaNaBazu.Predmeti.ToList();

                }
                cmbPredmeti.DisplayMember = "Naziv";
                cmbPredmeti.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }

        }
        private void UcitajOcjene()
        {
            List<int> ocjena = new List<int>()
                {
                    6,
                    7,
                    8,
                    9,
                    10
                };

            cmbOcjene.DataSource = ocjena;
        }
        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = korisnik.Uspjeh;
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
     
            try
            {
                int ocjena = int.Parse(cmbOcjene.SelectedItem.ToString());
                if (ocjena < 6 || ocjena > 10)
                    throw new Exception("Ocjena nije ispravna.");

                Predmeti odabraniPredmet = cmbPredmeti.SelectedItem as Predmeti;
                ProvjeriDaLiPredmetPostoji(odabraniPredmet);

                KorisniciPredmeti polozeniPredmet = new KorisniciPredmeti();
                polozeniPredmet.Predmet = odabraniPredmet;
                polozeniPredmet.Ocjena = ocjena;
                polozeniPredmet.Datum = dtpDatumPolaganja.Value.ToString("dd.MM.yyyy");
                korisnik.Uspjeh.Add(polozeniPredmet);
                konekcijaNaBazu.SaveChanges();

                UcitajPolozenePredmete();

            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void ProvjeriDaLiPredmetPostoji(Predmeti odabraniPredmet)
        {
            if (korisnik.Uspjeh.Where(x => x.Predmet.Id == odabraniPredmet.Id).Count() > 0)
                throw new Exception($"Predmet {odabraniPredmet} je vec evidentiran korisniku {korisnik}");
        }

        private void cbUcitajNepolozene_CheckedChanged(object sender, EventArgs e)
        {

            if (cbUcitajNepolozene.Checked)
            {

                #region "Preko foreach"
                //List<Predmeti> tempPredmeti = new List<Predmeti>();

                //foreach (var p in konekcijaNaBazu.Predmeti)
                //{

                //    foreach (var kp in korisnik.Uspjeh)
                //        if (p.Id != kp.Predmet.Id)
                //        {
                //            tempPredmeti.Add(p);
                //        }
                //}

                //UcitajPredmete(tempPredmeti);


                #endregion

                // Sa linq mnogo lakse i bolje
                var query = from c in konekcijaNaBazu.Predmeti.AsEnumerable()
                            where !(from o in korisnik.Uspjeh
                                    select o.Predmet.Id)
                                   .Contains(c.Id)
                            select c;

                UcitajPredmete(query.ToList());

            }
            else
                UcitajPredmete();

        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            var forma = new Izvjestaji(korisnik);
            forma.ShowDialog();
        }

  
        private void btnASYNC_Click(object sender, EventArgs e)
        {

            // Textbox, i ostale elemente moramo izvan async, inace nece thread moci prepoznati
            Predmeti odabraniPredmet = cmbPredmeti.SelectedItem as Predmeti;

            var DodavanjePredmetaTask = Task.Run(() =>
            {
                try
                {
                    for (int i = 0; i < 500; i++)
                    {

                        KorisniciPredmeti kp = new KorisniciPredmeti();

                        kp.Predmet = odabraniPredmet;
                        kp.Ocjena = 6;
                        kp.Datum = DateTime.Now.ToString("dd.MM.yyyy");

                        // Uvezivanje sa korisnikom
                        korisnik.Uspjeh.Add(kp);

                        // Spasi u bazu
                        konekcijaNaBazu.SaveChanges();
                    }
                } catch (Exception ex)
                {
                    MboxHelper.PrikaziGresku(ex);
                }
            });

            var cekanje = DodavanjePredmetaTask.GetAwaiter();//AWAIT
            cekanje.OnCompleted(() => {
                MessageBox.Show("Uspješno je dodano 500 predmeta");
                // Refresh tabele
                UcitajPolozenePredmete();
            });
        }
    }
}
