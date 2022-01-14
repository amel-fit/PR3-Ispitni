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
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        private Student _odabrani;


        public frmNoviScanIspitaIB200002(Student odabrani)
        {
            InitializeComponent();
            _odabrani = odabrani;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var noviScan = (new KorisniciIspitiScan
            {
                Student = _odabrani,
                Napomena = textBox1.Text,
                Varanje = checkBox1.Checked == true ? true : false,
                SkeniranIspit = ImageHelper.FromImageToByte(pictureBox1.Image),
            });
            _baza.KorisniciIspitiScan.Add(noviScan);
            _baza.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmNoviScanIspitaIB200002_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = _baza.Predmet.ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
