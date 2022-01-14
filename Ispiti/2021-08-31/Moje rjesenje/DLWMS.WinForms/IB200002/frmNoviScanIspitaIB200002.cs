using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB200002
{
    public partial class frmNoviScanIspitaIB200002 : Form
    {
        private Student _student;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;

        public frmNoviScanIspitaIB200002(Student student)
        {
            InitializeComponent();
           _student = student;
        }

        private void btmSpasi_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var noviScan = new KorisniciIspitiScan()
                {
                    Student = _student,
                    Napomena = txtNapomena.Text,
                    Varanje = cbVaranje.Checked,
                    Predmet = cmbPredmet.SelectedItem as Predmet,
                    SkeniranIspit = ImageHelper.FromImageToByte(pictureBox1.Image)
                };
                _baza.KorisniciIspitiScan.Add(noviScan);
                _baza.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(cmbPredmet, errorProvider1, "Obavezna vrijednost!") &&
                Validator.ValidirajKontrolu(pictureBox1, errorProvider1, "Obavezna vrijednost!") &&
                Validator.ValidirajKontrolu(txtNapomena, errorProvider1, "Obavezna vrijednost!");
        }

        private void frmNoviScanIspitaIB200002_Load(object sender, EventArgs e)
        {
            cmbPredmet.DataSource = _baza.Predmet.ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
