using DLWMS.Data;
using DLWMS.Data.IB230046;
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

namespace DLWMS.WinForms.IB230046
{
    public partial class frmNovaPorukaIB230046 : Form
    {
        DLWMSDbContext db = new();
        Student Student { get; set; }
        public frmNovaPorukaIB230046(Student student)
        {
            InitializeComponent();
            Student = student;
            cbPredmet.DataSource = db.Predmeti.ToArray();
            
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            var result = fdSlikaSelect.ShowDialog();
            if (result != DialogResult.OK) return;

            var strm = fdSlikaSelect.OpenFile();
            var img = Image.FromStream(strm);
            pbSlika.Image = img;
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            if (!ValidanUnos()) return;
            StudentiPorukeIB230046 sp = new()
            {
                PredmetId = (cbPredmet.SelectedItem as PredmetIB230046).Id,
                StudentId = Student.Id,
                Slika = ImageHelper.FromImageToByte(pbSlika.Image),
                Sadrzaj = rtSadrzaj.Text,
                Validnost = dtpValidnost.Value
            };
            db.studentiPorukeIB230046.Add(sp);
            db.SaveChanges();
            this.DialogResult = DialogResult.OK;
            //MessageBox.Show("Poruka uspjesno poslana");
        }

        private bool ValidanUnos()
        {
            return Validator.ValidirajKontrolu(cbPredmet, err, Kljucevi.PodaciNisuValidni)
                && Validator.ValidirajKontrolu(dtpValidnost, err, Kljucevi.PodaciNisuValidni)
                && Validator.ValidirajKontrolu(rtSadrzaj, err, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(pbSlika, err, Kljucevi.ObaveznaVrijednost);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
