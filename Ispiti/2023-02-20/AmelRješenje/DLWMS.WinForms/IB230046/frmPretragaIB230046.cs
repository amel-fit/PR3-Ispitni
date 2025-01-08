using DLWMS.Data;
using DLWMS.Data.IB230046;
using DLWMS.WinForms.IB230046;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms
{
    public partial class frmPretragaIB230046 : Form
    {
        DLWMSDbContext db = new();
        public frmPretragaIB230046()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
            dtpDatumOd.Value = new DateTime(2000, 1, 1);
            cbOcjenaOd.SelectedIndex = 0;
            cbOcjenaDo.SelectedIndex = 3;

        }


        private void SetDataSource<T>(IEnumerable<T> source)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = source;
        }
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (cbOcjenaOd.Text == "" || cbOcjenaDo.Text == "") return;
            DateTime searchDateFrom = dtpDatumOd.Value.Date;
            int ocjenaFrom = int.Parse(cbOcjenaOd.Text);

            DateTime searchDateTo = dtpDatumDo.Value.Date;
            int ocjenaTo = int.Parse(cbOcjenaDo.Text);


            var StudentiPredmetiList = db.StudentiPredmeti.Include(x => x.Student).Include(x => x.Predmet).Where(sp => ocjenaFrom <= sp.Ocjena && sp.Ocjena <= ocjenaTo && searchDateFrom < sp.Datum && sp.Datum < searchDateTo).ToList();
            if (!StudentiPredmetiList.Any())
            {
                MessageBox.Show($"U periodu od {searchDateFrom.ToString("dd.MM.yyyy")} – {searchDateTo.ToString("dd.MM.yyyy")}. godine ne postoje evidentirane ocjene u opsegu od {ocjenaFrom} do {ocjenaTo} za bilo kojeg studenta.");
                return;
            }
            List<dtoStudentPredmetIB230046> dtoStudentPredmetList = new();

            foreach (var sp in StudentiPredmetiList)
            {
                dtoStudentPredmetList.Add(new dtoStudentPredmetIB230046(sp.Student, sp.Predmet, sp));
            }

            SetDataSource(dtoStudentPredmetList);

        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.ColumnIndex == dgvStudenti.Columns["btnPoruke"].Index)
            {
                //Button clicked:
                var row = dgvStudenti.Rows[e.RowIndex];
                var dto = row.DataBoundItem as dtoStudentPredmetIB230046;
                Student student = dto.student;
                PredmetIB230046 predmet = dto.predmet;
                new frmPorukeIB230046(student, predmet).Show();
            }
        }
    }
}
