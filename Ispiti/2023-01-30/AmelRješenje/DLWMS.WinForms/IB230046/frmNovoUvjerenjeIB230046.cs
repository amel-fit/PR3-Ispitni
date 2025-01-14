using DLWMS.Data;
using DLWMS.Data.IB230046;
using DLWMS.WinForms.Helpers;
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

namespace DLWMS.WinForms.IB230046
{
    public partial class frmNovoUvjerenjeIB230046 : Form
    {
        public Student student { get; set; }
        public DLWMSDbContext dbContext { get; set; } = new();
        public frmNovoUvjerenjeIB230046(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (!ValidUnos()) return;

            var su = new StudentiUvjerenjaIB230046()
            {

                StudentId = student.Id,

                Svrha = rtSvrha.Text,
                Vrsta = cmbVrsta.Text,
                Uplatnica = ImageHelper.FromImageToByte(pbUplatnica.Image),

                VrijemeKreiranja = DateTime.Now,
                Printano = false
            };
            dbContext.StudentiUvjerenjaIB230046.Add(su);
            dbContext.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }

        private bool ValidUnos()
        {
            return DLWMS.WinForms.Helpers.Validator.ValidirajKontrolu(cmbVrsta, err, Kljucevi.PodaciNisuValidni)
                && DLWMS.WinForms.Helpers.Validator.ValidirajKontrolu(rtSvrha, err, Kljucevi.ObaveznaVrijednost)
                && DLWMS.WinForms.Helpers.Validator.ValidirajKontrolu(pbUplatnica, err, Kljucevi.ObaveznaVrijednost);
        }

        private void pbUplatnica_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            var file = fileDialog.OpenFile();
            pbUplatnica.Image = Image.FromStream(file);
        }
    }
}
