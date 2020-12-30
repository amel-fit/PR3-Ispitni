using cSharpIntroWinForms.IB190073;
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

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
        private Korisnik korisnik;
        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;
        private List<int> ListaOcjena = new List<int>();

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
            korisnik = konekcijaNaBazu.Korisnici.FirstOrDefault();
        }
        public KorisniciPolozeniPredmeti(Korisnik korisnik):this()
        {
            this.korisnik = korisnik;
        }
        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajGodineStudija();
                UcitajPredmete();
                UcitajPolozene();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }

        private void UcitajGodineStudija()
        {
            cmbGodineStudija.DataSource = konekcijaNaBazu.GodineStudija.ToList();
            cmbGodineStudija.DisplayMember = "Naziv";
            cmbGodineStudija.ValueMember = "Id";
        }

        private void UcitajPolozene()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = korisnik.Uspjeh;
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = konekcijaNaBazu.Predmeti.ToList();
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            if(ValidirajUnos())
            {
                if (!PostojiPredmet())
                {
                    konekcijaNaBazu.KorisniciPredmeti.Add(new KorisniciPredmeti()
                    {
                        Korisnik = korisnik,
                        Ocjena = int.Parse(txtOcjena.Text),
                        Predmet = cmbPredmeti.SelectedItem as Predmeti,
                        Datum = dtpDatumPolaganja.Value.ToShortDateString(),
                        GodineStudija = cmbGodineStudija.SelectedItem as GodineStudija
                    });
                    konekcijaNaBazu.SaveChanges();
                    MessageBox.Show($"Predmet uspjesno dodan!");
                    UcitajPolozene();
                }
                else
                 MessageBox.Show($"Predmet vec postoji na toj godini, ili podaci nisu validni!");
            }

        }

        private bool PostojiPredmet()
        {
            foreach (var polozeni in korisnik.Uspjeh)
                if (polozeni.GodineStudija.Id == (cmbGodineStudija.SelectedItem as GodineStudija).Id && polozeni.Predmet.Id == (cmbPredmeti.SelectedItem as Predmeti).Id)
                    return true;
            return false;
        }

        private bool ValidirajUnos()
        {
            return Validator.ObaveznoPolje(cmbPredmeti, err, Validator.porObaveznaVrijednost) &&
                Validator.ObaveznoPolje(cmbGodineStudija, err, Validator.porObaveznaVrijednost)
                && int.Parse(txtOcjena.Text) >= 6 && int.Parse(txtOcjena.Text) <= 10;
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            dtoKorisnikIzvjestaj objekatIzvjestaj = new dtoKorisnikIzvjestaj();
            objekatIzvjestaj.Ime = korisnik.Ime;
            objekatIzvjestaj.Prezime = korisnik.Prezime;
            objekatIzvjestaj.Polozeni = korisnik.Uspjeh;
            frmIzvjestaj izvjestaj = new frmIzvjestaj(objekatIzvjestaj);
            izvjestaj.ShowDialog();
        }
    }


    public class dtoKorisnikIzvjestaj
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public List<KorisniciPredmeti> Polozeni { get; set; }
    }
}
