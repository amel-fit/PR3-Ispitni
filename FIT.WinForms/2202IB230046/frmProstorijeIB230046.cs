using FIT.Data._2202IB230046;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms._2202IB230046
{
    public partial class frmProstorijeIB230046 : Form
    {
        public DLWMSDbContext dbContext = new();
        public frmProstorijeIB230046()
        {
            InitializeComponent();
            dgvProstorije.AutoGenerateColumns = false;
            SetSource();
        }

        private void SetSource()
        {
            dgvProstorije.DataSource = null;
            var lstProstorije = dbContext.Prostorije.ToList();
            foreach (var p in lstProstorije)
            {
                p.LogoIMG = Image.FromStream(new MemoryStream(p.Logo));
                p.BrPredmeta = dbContext.Nastave.Where(n => n.ProstorijaId == p.Id).ToList().Count();
            }
            dgvProstorije.DataSource = lstProstorije;
        }

        private void btnNovaProstorija_Click(object sender, EventArgs e)
        {
            var result = new frmNovaProstorijaIB230046().ShowDialog();
            if (result == DialogResult.OK)
                SetSource();
        }

        private void btnNovaProstorija_Click_1(object sender, EventArgs e)
        {
            var result = new frmNovaProstorijaIB230046().ShowDialog();
            if (result == DialogResult.OK)
                SetSource();
        }

        private void dgvProstorije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == btnNastava.Index)
            {
                //Nastava button
                new frmNastavaIB230046(dgvProstorije.Rows[e.RowIndex].DataBoundItem as Prostorija).Show();

            }else if(e.ColumnIndex == btnPrisustvo.Index)
            {
                //Prisustvo Button
                new frmPrisustvoIB230046(dgvProstorije.Rows[e.RowIndex].DataBoundItem as Prostorija).Show();
            }
        }
    }
}
