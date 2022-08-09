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
            _studenti = _db.Studenti.Where(s => s.GodinaStudija == _godina && (s.Ime.Contains(_filter) || s.Prezime.Contains(_filter) || _filter == "")).ToList();
            if (_studenti != null)
            {
                DataTable tblstudenti = new DataTable();
                tblstudenti.Columns.Add("ImePrezime");
                tblstudenti.Columns.Add("GodinaStudija");
                tblstudenti.Columns.Add("ProsjecnaOcjena");
                for (int i = 0; i < _studenti.Count(); i++)
                {
                    DataRow student = tblstudenti.NewRow();
                    List<StudentPredmet> studentiPredmeti = _db.StudentiPredmeti.ToList();
                    double suma = 0;
                    double brojac = 0;
                    double prosjek = 0;
                    for (int j = 0; j < studentiPredmeti.Count(); j++)
                    {
                        if (_studenti[i] == studentiPredmeti[j].Student)
                        {
                            suma += studentiPredmeti[j].Ocjena;
                            brojac++;
                            prosjek = suma / brojac;
                        }
                    }
                    student["ImePrezime"] = _studenti[i];
                    student["GodinaStudija"] = _studenti[i].GodinaStudija;
                    student["ProsjecnaOcjena"] = (prosjek == 0) ? 5 : prosjek;
                    tblstudenti.Rows.Add(student);
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
