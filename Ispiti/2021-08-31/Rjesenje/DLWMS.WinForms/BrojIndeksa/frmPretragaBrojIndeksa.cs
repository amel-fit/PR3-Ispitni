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

namespace DLWMS.WinForms.BrojIndeksa
{
    public partial class frmPretragaBrojIndeksa : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        string _filter;
        List<string> _samoglasnici = new List<string> { "a", "e", "i", "o", "u" };
        List<string> _znakovi = new List<string> { "?", "!", "<", ">", "*" };
        public frmPretragaBrojIndeksa()
        {
            InitializeComponent();
            dgvStudentiStatistika.AutoGenerateColumns = false;
        }

        private void frmPretragaBrojIndeksa_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente(List<StudentiPolozeniStatistika> sps=null)
        {
            dgvStudentiStatistika.DataSource = null;
            dgvStudentiStatistika.DataSource = sps ?? Sve();
            if((dgvStudentiStatistika.DataSource as List<StudentiPolozeniStatistika>).Count!=0)
            {
                lblProsjek.Text = $"Prosjek prikazanih ocjena: {(dgvStudentiStatistika.DataSource as List<StudentiPolozeniStatistika>).Average(x => x.Prosjek)}";
                lblNajveci.Text = $"Najveci prosjek ostvario: {Najveci()} ";
            }
            else
            {
                lblProsjek.Text = $"Prosjek prikazanih ocjena: 0";
                lblNajveci.Text = $"Najveci prosjek ostvario: NOT SET ";
            }

        }

        private string Najveci()
        {
            var dgv = dgvStudentiStatistika.DataSource as List<StudentiPolozeniStatistika>;
            int maxIndeks = 0;
            double maxAverage = 0;
            if (dgv.Count == 0)
                return "0";
            for (int i = 0; i < dgv.Count; i++)
            {
                if(dgv[i].Prosjek>maxAverage)
                {
                    maxAverage = dgv[i].Prosjek;
                    maxIndeks = i;
                }
            }

            return $"{dgv[maxIndeks].Student}";
        }

        private List<StudentiPolozeniStatistika> Sve()
        {
            var sps = new List<StudentiPolozeniStatistika>();
            var studenti = _baza.StudentiPredmeti.ToList().Select(x=>x.Student).Distinct().ToList();
            for (int i = 0; i < studenti.Count; i++)
            {
                sps.Add(new StudentiPolozeniStatistika
                {
                    Student = studenti[i],
                    Polozeni = string.Join(";", _baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == studenti[i].Id).Select(x => x.Predmet.Naziv).ToList()),
                    Broj = _baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == studenti[i].Id).Count(),
                    Prosjek = _baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == studenti[i].Id).Average(x => x.Ocjena)
                });
            }
            return sps;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            _filter = txtPretraga.Text.ToLower();
            if (string.IsNullOrEmpty(_filter))
                UcitajStudente();
            else
                Filtriraj();
        }

        private void Filtriraj()
        {
            var sps = new List<StudentiPolozeniStatistika>();
            var studenti = _baza.StudentiPredmeti.
                            Where(x=>x.Student.Ime.ToLower().Contains(_filter) || x.Student.Prezime.ToLower().Contains(_filter)
                            ).ToList().Select(x => x.Student).Distinct().ToList();
            for (int i = 0; i < studenti.Count; i++)
            {
                sps.Add(new StudentiPolozeniStatistika
                {
                    Student = studenti[i],
                    Polozeni = string.Join(";", _baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == studenti[i].Id).Select(x => x.Predmet.Naziv).ToList()),
                    Broj = _baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == studenti[i].Id).Count(),
                    Prosjek = _baza.StudentiPredmeti.ToList().Where(x => x.Student.Id == studenti[i].Id).Average(x => x.Ocjena)
                });
            }

            UcitajStudente(sps);
        }

        private void dgvStudentiStatistika_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==4)
            {
                var student = (dgvStudentiStatistika.Rows[e.RowIndex].DataBoundItem as StudentiPolozeniStatistika).Student;
                frmScanIspitaBrojIndeksa frm = new frmScanIspitaBrojIndeksa(student);
                frm.ShowDialog();
            }
        }

        private async void btnThreading_Click(object sender, EventArgs e)
        {
            var _text = txtThreading.Text.ToLower();
            int samoglasnici = 0;
            int znakovi = 0;
            int suglasnici = 0;
            await Task.Run(() => 
            {
                samoglasnici = _text.Where(x => _samoglasnici.Contains(x.ToString())).Count();
                znakovi = _text.Where(x => _znakovi.Contains(x.ToString())).Count();
                suglasnici = _text.Length - samoglasnici - znakovi;
            });
            Action action = new Action(() =>txtInfo.Text=$"Sadrzaj info: {Environment.NewLine}" +
            $"\tSamoglasnika: {samoglasnici} {Environment.NewLine}" +
            $"\tSuglasnika: {suglasnici} {Environment.NewLine}" +
            $"\tZnakova: {znakovi}");
            BeginInvoke(action);
        }
    }
}
