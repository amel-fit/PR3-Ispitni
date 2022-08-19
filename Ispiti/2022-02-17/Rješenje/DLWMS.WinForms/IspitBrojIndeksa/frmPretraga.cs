using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.DB;

namespace DLWMS.WinForms.IspitBrojIndeksa
{
    public partial class frmPretraga : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        List<Student> _studenti;
        string _filter;
        int _godina;

        public frmPretraga()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void UcitajPodatke()
        {
            _filter = string.IsNullOrEmpty(txtImePrezime.Text) ? "" : txtImePrezime.Text;
            _godina = string.IsNullOrEmpty(cmbGodinaStudija.Text) ? 0 : int.Parse(cmbGodinaStudija.SelectedItem.ToString());
            _studenti = _db.Studenti.Where(s => s.GodinaStudija == _godina && 
            (s.Ime.ToLower().Contains(_filter.ToLower()) || s.Prezime.ToLower().Contains(_filter.ToLower()) || _filter == "")).ToList();
            if (_studenti != null)
            {
                DataTable tblstudenti = new DataTable();
                tblstudenti.Columns.Add("ImePrezime");
                tblstudenti.Columns.Add("GodinaStudija");
                tblstudenti.Columns.Add("ProsjecnaOcjena");
                for (int i = 0; i < _studenti.Count(); i++)
                {
                    var student = _studenti[i];
                    List<StudentPredmet> studentiPredmeti = _db.StudentiPredmeti.Where(x => x.Student.Id == student.Id).ToList();              
                    DataRow red = tblstudenti.NewRow();
                    red["ImePrezime"] = student;
                    red["GodinaStudija"] = student.GodinaStudija;
                    red["ProsjecnaOcjena"] = studentiPredmeti.Count() == 0 ? 5 : studentiPredmeti.Average(x => x.Ocjena);
                    tblstudenti.Rows.Add(red);
                }
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = tblstudenti;
            }
            else
            {
                dgvStudenti.DataSource = null;
            }
        }

        private void cmbGodinaStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int index = dgvStudenti.SelectedCells[0].RowIndex;
                var student = _studenti[index];
                frmKonsultacije forma = new frmKonsultacije(student);
                forma.ShowDialog();
            }
        }
    }
}
