using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
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
    public partial class frmScanIspitaBrojIndeksa : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        private Student student;

        public frmScanIspitaBrojIndeksa()
        {
            InitializeComponent();
            dgvSken.AutoGenerateColumns = false;
        }

        public frmScanIspitaBrojIndeksa(Student student) : this()
        {
            this.student = student;
        }

        private void frmScanIspitaBrojIndeksa_Load(object sender, EventArgs e)
        {
            label1.Text += student.ToString();
            UcitajSkenove();
        }

        private void UcitajSkenove()
        {
            dgvSken.DataSource = _baza.StudentiIspitiScan.Where(x => x.Student.Id == student.Id).ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmNoviScanIspitaBrojIndeks frm = new frmNoviScanIspitaBrojIndeks(student);
            frm.ShowDialog();
            UcitajSkenove();
        }

        private void dgvSken_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sken = dgvSken.Rows[e.RowIndex].DataBoundItem as StudentiIspitiScan;
            if(e.ColumnIndex==5)
            {
                if (MessageBox.Show("Da li ste sigurni?","?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)
                    ==DialogResult.Yes)
                {
                    _baza.StudentiIspitiScan.Remove(sken);
                    _baza.SaveChanges();
                    UcitajSkenove();
                }
            }
            else
            {
                frmNoviScanIspitaBrojIndeks frm = new frmNoviScanIspitaBrojIndeks(sken);
                frm.ShowDialog();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var skenovi= dgvSken.DataSource as List<StudentiIspitiScan>;
            frmIzvjestaji frm = new frmIzvjestaji(skenovi);
            frm.ShowDialog();
        }
    }
}
