using DLWMS.Data;
using DLWMS.Data.IB210000;
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

namespace DLWMS.WinForms.IB210000
{
    public partial class frmNovoUvjerenjeIB210000 : Form
    {
        private Student student;
        DLWMSDbContext db = KonekcijaIB210000.db;
        public frmNovoUvjerenjeIB210000(Student std)
        {
            InitializeComponent();
            student = std;
            UcitajVrste();
        }

        private void UcitajVrste()
        {
            List<string> vrste = new List<string>();
            vrste.Add("Uvjerenje o statusu studenta");
            vrste.Add("Uvjerenje o položenim ispitima");
            vrste.Add("Uvjerenje o prosjeku studenta");
            cmbVrsta.DataSource=vrste;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(podaciValidni())
            {
                var vrsta = cmbVrsta.SelectedItem.ToString();
                var svrha = txtSvrha.Text;
                var slika = ImageHelper.FromImageToByte(pbSlika.Image);

                var novo = new StudentUvjerenjeIB210000()
                {
                    Student = student,
                    Svrha = svrha,
                    Vrsta = vrsta,
                    Uplatnica = slika,
                    Printano = false,
                    Datum = DateTime.Now
                };

                db.StudentiUvjerenja.Add(novo);
                db.SaveChanges();
                MessageBox.Show("Uspjesno dodano uvjerenje!");
            }
        }

       
        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            var rd = new OpenFileDialog();
            if(rd.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image=Image.FromFile(rd.FileName);
            }
        }

        private bool podaciValidni()
        {
            return Validator.ValidirajKontrolu(cmbVrsta, err, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtSvrha, err, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(pbSlika, err, Kljucevi.ObaveznaVrijednost);
        }

    }
}
