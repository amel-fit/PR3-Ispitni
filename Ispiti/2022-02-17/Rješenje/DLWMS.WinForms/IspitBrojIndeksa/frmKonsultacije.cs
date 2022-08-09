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
using DLWMS.WinForms.P5;
using System.Threading;

namespace DLWMS.WinForms.IspitBrojIndeksa
{
    public partial class frmKonsultacije : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        List<StudentKonsultacija> _konsultacije;
        Student _student;
        ErrorProvider _error = new ErrorProvider();
        public frmKonsultacije(Student student)
        {
            InitializeComponent();
            _student = student;
        }

        private void frmKonsultacije_Load(object sender, EventArgs e)
        {
            dgvKonsultacije.AutoGenerateColumns = false;
            lblStudent.Text = $"Lista zahtjeva za konsultacije studenta {_student}.";
            cmbPredmeti.DataSource = _db.Predmeti.ToList();
            UcitajKonsultacije();
        }

        private void UcitajKonsultacije()
        {
            _konsultacije = _db.StudentiKonsultacije.Where(k => k.Student.Indeks == _student.Indeks).ToList();
            dgvKonsultacije.DataSource = _konsultacije;
            this.Text = $"Broj ukupnih prikaza: {_konsultacije.Count()}";
        }

        private void dgvKonsultacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int index = dgvKonsultacije.SelectedCells[0].RowIndex;
                var konsultacija = _konsultacije[index];
                DialogResult upozorenje = MessageBox.Show("Da li sigurno želite obrisati termin konsultacije?", "Upozorenje!", MessageBoxButtons.YesNo);
                if (upozorenje == DialogResult.Yes && konsultacija.VrijemeOdrzavanja >= DateTime.Now)
                {
                    _db.StudentiKonsultacije.Remove(konsultacija);
                    _db.SaveChanges();
                    UcitajKonsultacije();
                }
                else if (upozorenje == DialogResult.Yes && konsultacija.VrijemeOdrzavanja < DateTime.Now)
                {
                    MessageBox.Show("Nije moguće obrisati termin već održane konsultacije!", "Upozorenje!");
                }
            }
        }

        private void btnDodajZahtjev_Click(object sender, EventArgs e)
        {
            frmNovaKonsultacija forma = new frmNovaKonsultacija(_student);
            forma.ShowDialog();
            if (forma.KonsultacijaDodana())
            {
                UcitajKonsultacije();
            } 
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            frmIzvjestajKonsultacija forma = new frmIzvjestajKonsultacija(_student, _konsultacije);
            forma.ShowDialog();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                txtInfo.Clear();
                Predmet predmet = cmbPredmeti.SelectedItem as Predmet;
                await Task.Run(() => {
                    int brojZahtjeva = int.Parse(txtBrojZahtjeva.Text.ToString());
                    string info; 
                    for (int i = 0; i < brojZahtjeva; i++)
                    {
                        Thread.Sleep(500);
                        StudentKonsultacija novaKonsultacija = new StudentKonsultacija
                        {
                            Student = _student,
                            Predmet = predmet,
                            VrijemeOdrzavanja = DateTime.Now,
                            Napomena = $"Dodavanje u threadu ({i+1})"
                        };
                        _db.StudentiKonsultacije.Add(novaKonsultacija);
                        info = $"Za {_student} dodat novi zahtjev za konsultacijama -> {predmet} | ({DateTime.Now}) {Environment.NewLine}";
                        Action akcija = () => txtInfo.Text += info;
                        BeginInvoke(akcija);
                    }
                _db.SaveChanges();
                });
                MessageBox.Show($"Uspjesno ste dodali {txtBrojZahtjeva.Text} zahtjeva za konsultacije!", "Obavijest.");
                txtBrojZahtjeva.Clear();
                UcitajKonsultacije();
            }
        }

        private bool Validiraj()
        {
            return Validator.ValidirajKontrolu(txtBrojZahtjeva, _error, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cmbPredmeti, _error, Poruke.ObaveznaVrijednost);
        }
    }
}
