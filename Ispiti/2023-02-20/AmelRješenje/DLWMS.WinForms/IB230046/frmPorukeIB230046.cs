using DLWMS.Data;
using DLWMS.Data.IB230046;
using DLWMS.WinForms.Helpers;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
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

namespace DLWMS.WinForms.IB230046
{
    public partial class frmPorukeIB230046 : Form
    {
        DLWMSDbContext db = new();
        public Student student { get; set; }
        public PredmetIB230046 predmet { get; set; }
        public frmPorukeIB230046(Student s, PredmetIB230046 p)
        {
            InitializeComponent();
            dgvPoruke.AutoGenerateColumns = false;
            cbPredmet.DataSource = db.Predmeti.ToList();

            student = s;
            predmet = p;

            var lstPoruke = GetDTOPoruke();
            UcitajPoruke(lstPoruke);
            this.Text = $"Broj poruka: {lstPoruke.Count()}";

            lblImeStudenta.Text = $"Poruke studenta {student.Ime} {student.Prezime}";
        }

        private List<dtoStudentiPorukeIB230046> GetDTOPoruke()
        {
            List<dtoStudentiPorukeIB230046> lstStudentiPoruke = new();
            var lstSP = db.studentiPorukeIB230046.Where(sp => sp.StudentId == student.Id).ToList();
            foreach (var sp in lstSP)
            {
                if (sp.Validnost < DateTime.Now)
                    continue;
                var dtoSP = new dtoStudentiPorukeIB230046(sp);
                lstStudentiPoruke.Add(dtoSP);
            }
            return lstStudentiPoruke;
        }



        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidniUnosi()) return;
            if (int.Parse(txtBrojPoruka.Text) < 1) return;

            int brojPoruka = db.studentiPorukeIB230046.Count();
            int brojPorukaZaGenerisati = int.Parse(txtBrojPoruka.Text);

            await Task.Run(() =>
            {
                for (int i = 0; i < brojPorukaZaGenerisati; i++)
                {
                    StudentiPorukeIB230046 sp = new();
                    var SelectedPredmet = cbPredmet.Invoke(()
                        => cbPredmet.SelectedItem as PredmetIB230046);
                    sp.PredmetId = SelectedPredmet.Id;
                    sp.StudentId = student.Id;

                    var img = Image.FromFile("../../../Resources/Slicica.png");
                    sp.Slika = ImageHelper.FromImageToByte(img);

                    sp.Sadrzaj = $"{brojPoruka + i + 1}. Generisana poruka ";

                    sp.Validnost = dtpValidnost.Value;

                    string info = $"{DateTime.Now} -> Generisana poruka za {student.Ime} {student.Prezime} na predmetu {SelectedPredmet.Naziv}\n";
                    rtInfo.Invoke(() => rtInfo.AppendText(info));
                    db.studentiPorukeIB230046.Add(sp);
                }
            });

            db.SaveChanges();
            UcitajPoruke(GetDTOPoruke());
        }

        private bool ValidniUnosi()
        {
            return Validator.ValidirajKontrolu(txtBrojPoruka, err, Kljucevi.ObaveznaVrijednost) &&
                    Validator.ValidirajKontrolu(cbPredmet, err, Kljucevi.PodaciNisuValidni) &&
                    Validator.ValidirajKontrolu(dtpValidnost, err, Kljucevi.PodaciNisuValidni);
        }

        private void dgvPoruke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgvPoruke.Columns["Brisi"].Index)
            {
                //Brisi kliknuto
                var DTORowObject = dgvPoruke.Rows[e.RowIndex].DataBoundItem as dtoStudentiPorukeIB230046;
                StudentiPorukeIB230046 toRemove = db.studentiPorukeIB230046.FirstOrDefault(sp => sp.Id == DTORowObject.Id);
                //db.studentiPorukeIB230046.ExecuteDelete()
                db.studentiPorukeIB230046.Remove(toRemove);
                db.SaveChanges();
                UcitajPoruke(GetDTOPoruke());
            }
        }

        private void UcitajPoruke<T>(IEnumerable<T> source)
        {
            dgvPoruke.DataSource = null;
            dgvPoruke.DataSource = source;
        }


    }
}
