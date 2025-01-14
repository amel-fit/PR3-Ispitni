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
    public partial class frmStudentInfoIB230046 : Form
    {
        public frmStudentInfoIB230046(dtoStudent s)
        {
            InitializeComponent();
            this.Text = s.BrojIndeksa;
            pbSlika.Image = ImageHelper.FromByteToImage(s.student.Slika);
            lblImePrezime.Text = s.ImePrezime;
            lblProsjek.Text += s.Prosjek;

        }
    }
}
