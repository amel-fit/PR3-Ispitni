using DLWMS.Data;
using DLWMS.Data.IB230046;
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
    public partial class frmPretragaIB230046 : Form
    {
        public DLWMSDbContext db { get; set; } = new();
        public frmPretragaIB230046()
        {
            InitializeComponent();

            //SetSource(getDTOStudent());
        }

        private IEnumerable<dtoStudent> getDTOStudent()
        {
            var lstStudenti = new List<dtoStudent>();
            foreach (var student in db.Studenti.ToArray())
            {
                if (PassesSearchParams(student))
                    lstStudenti.Add(new dtoStudent(student));
            }
            if (!lstStudenti.Any())
                MboxNoResults();
            return lstStudenti;
        }

        private void MboxNoResults()
        {
            string msg = "";
            string spola = "";
            var datumOd = dtpOd.Value;
            var datumDo = dtpDo.Value;
            if (cmbSpol.Text != db.Spolovi.First(s => s.Id == 1).Naziv)
            {

            }
            if (cmbSpol.Text == "Muški")
                spola = " muškog spola ";
            else
                spola = " ženskog spola ";
            MessageBox.Show($"Ne postoje studenti{spola}rođeni od {datumOd} - {datumDo}");
        }

        private bool PassesSearchParams(Student student)
        {
            var spol = db.Spolovi.First(s => s.Id == student.SpolId);
            var otherSpol = db.Spolovi.First(s => s.Id == 1);
            return dtpOd.Value < student.DatumRodjenja
                && student.DatumRodjenja < dtpDo.Value
                && (spol.Naziv == cmbSpol.Text || cmbSpol.Text == otherSpol.Naziv);
        }

        private void SetSource(IEnumerable<dtoStudent> source)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = source;
        }

        private void RefreshResults(object sender, EventArgs e)
        {
            SetSource(getDTOStudent());
        }

        private void frmPretragaIB230046_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;

            cmbSpol.SelectedIndexChanged -= RefreshResults;
            dtpOd.ValueChanged -= RefreshResults;

            cmbSpol.DataSource = db.Spolovi.ToArray();
            cmbSpol.SelectedIndex = 0;
            dtpOd.Value = new DateTime(1990, 1, 1);

            cmbSpol.SelectedIndexChanged += RefreshResults;
            dtpOd.ValueChanged += RefreshResults;

            SetSource(getDTOStudent());

        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
            var s = dgvStudenti.Rows[e.RowIndex].DataBoundItem as dtoStudent;
            if (e.ColumnIndex == dgvStudenti.Columns["Uvjerenja"].Index)
            {
                new frmUvjerenjaIB230046(s.student).Show();
            }
            else
            {
                new frmStudentInfoIB230046(s).Show();
            }
        }
    }
}
