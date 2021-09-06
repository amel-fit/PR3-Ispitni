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

namespace DLWMS.WinForms.BrojIndeksa
{
    public partial class frmNoviScanIspitaBrojIndeks : Form
    {
        private Student student;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        private StudentiIspitiScan sken;
        bool _view = false;

        public frmNoviScanIspitaBrojIndeks()
        {
            InitializeComponent();
        }

        public frmNoviScanIspitaBrojIndeks(Student student) : this()
        {
            this.student = student;
        }

        public frmNoviScanIspitaBrojIndeks(StudentiIspitiScan sken) : this()
        {
            this.sken = sken;
            _view = true;
        }

        private void frmNoviScanIspitaBrojIndeks_Load(object sender, EventArgs e)
        {
            if(_view)
            {
                cbPredmeti.Text = sken.Predmet.ToString();
                cbPredmeti.Enabled = false;
                txtNapomena.Text = sken.Napomena;
                txtNapomena.Enabled = false;
                cbVaranje.Checked = sken.Varanje;
                cbVaranje.Enabled = false;
                pbSlika.Image = ImageHelper.FromByteToImage(sken.Sken);
                pbSlika.Enabled = false;
                btnSpasi.Enabled = false;
            }
            else
                UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            cbPredmeti.DataSource = _baza.Predmet.ToList();
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if(Validno())
            {
                _baza.StudentiIspitiScan.Add(new StudentiIspitiScan
                {
                    Student = student,
                    Predmet = cbPredmeti.SelectedItem as Predmet,
                    Napomena = txtNapomena.Text,
                    Sken = ImageHelper.FromImageToByte(pbSlika.Image),
                    Varanje = cbVaranje.Checked
                });
                _baza.SaveChanges();
                Close();
            }     
        }

        private bool Validno()
        {
            return Validator.ValidirajKontrolu(cbPredmeti, err, Poruke.ObaveznaVrijednost) &&
                    Validator.ValidirajKontrolu(txtNapomena, err, Poruke.ObaveznaVrijednost) &&
                    Validator.ValidirajKontrolu(pbSlika, err, Poruke.ObaveznaVrijednost);
        }
    }
}
