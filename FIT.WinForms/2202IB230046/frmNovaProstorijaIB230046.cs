using FIT.Data;
using FIT.Data._2202IB230046;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms._2202IB230046
{
    public partial class frmNovaProstorijaIB230046 : Form
    {
        public DLWMSDbContext DbContext = new();
        public frmNovaProstorijaIB230046()
        {
            InitializeComponent();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            var result = fd.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbLogo.Image = Image.FromStream(fd.OpenFile());
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!Validiraj()) return;
            Image logo = pbLogo.Image;
            string naziv = txtNaziv.Text;
            string oznaka = txtOznaka.Text;
            int kapacitet = int.Parse(txtKapacitet.Text);
            DbContext.Prostorije.Add(new Prostorija()
                                        {
                                            Naziv = naziv,
                                            Oznaka = oznaka,
                                            Kapacitet = kapacitet,
                                            Logo = logo.ToByteArray()
                                        });
            DbContext.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }

        private bool Validiraj()
        {
            bool KapacitetJeBroj = true ;
            try
            {
                int parsed = int.Parse(txtKapacitet.Text);
            }
            catch (Exception)
            {
                KapacitetJeBroj = false;
            }
            return Helpers.Validator.ProvjeriUnos(pbLogo, err, "Obavezno")
                && Helpers.Validator.ProvjeriUnos(txtKapacitet, err, "Obavezno")
                && Helpers.Validator.ProvjeriUnos(txtNaziv, err, "Obavezno")
                && Helpers.Validator.ProvjeriUnos(txtOznaka, err, "Obavezno")
                && KapacitetJeBroj;


        }
    }
}
