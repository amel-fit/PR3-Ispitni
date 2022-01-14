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
    public partial class frmScanIspitaIB200002 : Form
    {
        private Student _student;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;

        public frmScanIspitaIB200002(Student student)
        {
            InitializeComponent();
            _student = student;
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmScanIspitaIB200002_Load(object sender, EventArgs e)
        {
            lblStudent.Text = _student.Ime + " " + _student.Prezime;
            UcitajScanove();
        }

        private void UcitajScanove()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _baza.KorisniciIspitiScan.Where(s=>s.Student.Id == _student.Id).ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var frmScanDodaj = new frmNoviScanIspitaIB200002(_student);
            if(frmScanDodaj.ShowDialog() == DialogResult.OK)
            {
                UcitajScanove();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var objekat = dataGridView1.SelectedRows[0].DataBoundItem as KorisniciIspitiScan;
            if(e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Jeste li sigurni?", "Obavijest", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _baza.KorisniciIspitiScan.Remove(objekat);
                    _baza.SaveChanges();
                    UcitajScanove();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var skeniranja = dataGridView1.DataSource as List<KorisniciIspitiScan>;
            var frmIzvjestaj = new frmIzvjestajiIB200002(skeniranja);
            frmIzvjestaj.Show();
        }
    }
}
