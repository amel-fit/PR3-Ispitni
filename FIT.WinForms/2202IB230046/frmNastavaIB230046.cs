using FIT.Data;
using FIT.Data._2202IB230046;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms._2202IB230046
{
    public partial class frmNastavaIB230046 : Form
    {
        public Prostorija prostorija { get; set; }
        public DLWMSDbContext dbContext = new();
        
        public frmNastavaIB230046()
        {
            InitializeComponent();
            cmbPredmet.UcitajPodatke(dbContext.Predmeti.ToList());
            var lstDani = new List<string>()
            {
                "Ponedjeljak",
                "Utorak",
                "Srijeda",
                "Četvrtak",
                "Petak",
                "Subota",
                "Nedelja"
            };
            cmbDan.DataSource = lstDani;
            var lstVrijeme = new List<string>()
            {
                "8 - 10",
                "10 - 12",
                "12 - 14",
                "16 - 18",
                "18 - 20"
            };
            cmbVrijeme.DataSource = lstVrijeme;

            dgvNastave.AutoGenerateColumns = false;
            
            
        }

        public frmNastavaIB230046(Prostorija p) : this()
        {
            prostorija = p;
            lblProstorija.Text = $"{p.Naziv} - {p.Oznaka}";
            SetSource();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            var tempNastava = new Nastava()
            {
                ProstorijaId = prostorija.Id,
                PredmetId = cmbPredmet.SelectedIndex + 1,
                VrijemeOdrzavanja = cmbVrijeme.Text,
                Dan = cmbDan.Text,
                Oznaka = $"{cmbPredmet}::{cmbDan.Text} :: {cmbVrijeme.Text}"
            };
            if (!Validiraj(tempNastava)) return;
            dbContext.Nastave.Add(new Nastava()
            {
                ProstorijaId = prostorija.Id,
                PredmetId = cmbPredmet.SelectedIndex + 1,
                VrijemeOdrzavanja = cmbVrijeme.Text,
                Dan = cmbDan.Text,
                Oznaka = $"{cmbPredmet.Text}::{cmbDan.Text} :: {cmbVrijeme.Text}"
            });
            dbContext.SaveChanges();
            SetSource();
        }

        private void SetSource()
        {
            dgvNastave.DataSource = null;
            var lstSource = dbContext.Nastave.Where(n => n.ProstorijaId == prostorija.Id).Include(n => n.Predmet).ToList();
            foreach (var n in lstSource) 
            {
                n.PredmetTXT = n.Predmet.Naziv;
            }
            dgvNastave.DataSource = lstSource;
        }

        private bool Validiraj(Nastava toValidate)
        {
            bool ValidCMB = 
            Helpers.Validator.ProvjeriUnos(cmbDan, err, "Neispravan Unos")
                && Helpers.Validator.ProvjeriUnos(cmbPredmet, err, "Neispravan Unos")
                && Helpers.Validator.ProvjeriUnos(cmbVrijeme, err, "Neispravan Unos");
            
            var lstNastave = dbContext.Nastave.Where(n => n.ProstorijaId == prostorija.Id && n.VrijemeOdrzavanja == toValidate.VrijemeOdrzavanja && n.Dan == toValidate.Dan).ToList();
            return !lstNastave.Any() && ValidCMB;

        }
    }
}
