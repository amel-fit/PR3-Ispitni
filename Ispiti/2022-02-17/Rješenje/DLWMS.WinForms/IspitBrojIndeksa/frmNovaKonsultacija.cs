using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.DB;
using DLWMS.WinForms.P5;

namespace DLWMS.WinForms.IspitBrojIndeksa
{
    public partial class frmNovaKonsultacija : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        Student _student;
        ErrorProvider _error = new ErrorProvider();

        public frmNovaKonsultacija(Student student)
        {
            InitializeComponent();
            _student = student;
        }

        private void frmNovaKonsultacija_Load(object sender, EventArgs e)
        {
            cmbPredmeti.DataSource = _db.Predmeti.ToList();
            dtpDatum.MinDate = DateTime.Now;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                StudentKonsultacija novaKonsultacija = new StudentKonsultacija
                {
                    Student = _student,
                    Predmet = cmbPredmeti.SelectedItem as Predmet,
                    VrijemeOdrzavanja = dtpDatum.Value,
                    Napomena = txtNapomena.Text
                };
                _db.StudentiKonsultacije.Add(novaKonsultacija);
                _db.SaveChanges();
                KonsultacijaDodana();
                Close();
            }
        }
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool KonsultacijaDodana()
        {
            return true;
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtNapomena, _error, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cmbPredmeti, _error, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(dtpDatum, _error, Poruke.ObaveznaVrijednost);
        }
    }
}
