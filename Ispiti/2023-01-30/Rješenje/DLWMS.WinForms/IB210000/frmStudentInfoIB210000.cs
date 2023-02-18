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
    public partial class frmStudentInfoIB210000 : Form
    {
        private dtoStudentIB210000 student;
        public frmStudentInfoIB210000(dtoStudentIB210000 std)
        {
            InitializeComponent();
            student = std;
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            lblImePrezime.Text = student.ImePrezime;
            lblProsjek.Text = "Prosjek: "+student.Prosjek;
            pbSlika.Image = ImageHelper.FromByteToImage(student.Student.Slika);
            Text = student.Indeks;
        }
    }
}
