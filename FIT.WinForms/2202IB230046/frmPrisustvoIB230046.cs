using FIT.Data;
using FIT.Data._2202IB230046;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
    public partial class frmPrisustvoIB230046 : Form
    {
        public Prostorija Prostorija { get; set; }
        public DLWMSDbContext dbContext { get; set; } = new();
        private bool doRefresh = false;
        public frmPrisustvoIB230046(Prostorija p) : this()
        {
            Prostorija = p;
            cmbNastava.UcitajPodatke(dbContext.Nastave.ToList(), "Oznaka");
            cmbNastava.SelectedIndex = 0;
            var lstStudent = dbContext.Studenti.ToList();
            foreach (var student in lstStudent)
            {
                student.StudentTXT = $"{student.Indeks} {student.Ime} {student.Prezime}";
            }
            cmbStudent.UcitajPodatke(lstStudent, "StudentTXT");
            dgvPrisustva.AutoGenerateColumns = false;
            SetSource();
            doRefresh = true;
        }

        private void SetSource()
        {

            dgvPrisustva.DataSource = null;
            int nastavaId = int.Parse((cmbNastava.SelectedValue as int?).ToString());
            var lstPrisustva = dbContext.Prisustva.Where(p => p.NastavaId == nastavaId).Include(p => p.Nastava).ToList();
            foreach (var prisustvo in lstPrisustva)
            {
                Student s = dbContext.Studenti.First(s => s.Id == prisustvo.StudentId);
                prisustvo.StudentTXT = $"{s.Indeks} {s.Ime} {s.Prezime}";
                prisustvo.OznakaTXT = prisustvo.Nastava.Oznaka;
            }
            dgvPrisustva.DataSource = lstPrisustva;

            lblProstorija.Text = Prostorija.Naziv;
            lblCounter.Text = $"{lstPrisustva.Count()}/{Prostorija.Kapacitet}";
        }

        public frmPrisustvoIB230046()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            int nastavaId = int.Parse((cmbNastava.SelectedValue as int?)?.ToString());
            int studentId = int.Parse((cmbStudent.SelectedValue as int?)?.ToString());
            if (dbContext.Prisustva.Any(p => p.StudentId == studentId && p.NastavaId == nastavaId)) return;
            dbContext.Prisustva.Add(
                new Prisustvo()
                {
                    NastavaId = nastavaId,
                    StudentId = studentId,
                }
            );
            dbContext.SaveChanges();
            SetSource();
        }

        private void cmbNastava_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doRefresh)
                SetSource();
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            int brojGeneracija = 0;
            try
            {
                brojGeneracija = int.Parse(textBox1.Text);
            }
            catch
            {
                return;
            }

            await Task.Run( () => 
            {
                int studentId = int.Parse((cmbStudent.Invoke(() => cmbStudent.SelectedValue) as int?)?.ToString());
                var lstNastave = dbContext.Nastave.Where(n => Prostorija.Id == n.ProstorijaId).ToList();
                foreach (var nastava in lstNastave)
                {

                    for (int i = 0; i < brojGeneracija; i++)
                    {
                        dbContext.Prisustva.Add(
                            new Prisustvo()
                            {
                                NastavaId = nastava.Id,
                                StudentId = studentId
                            }
                        );

                    }
                    Thread.Sleep(300);
                    rtInfo.Invoke(() =>
                    {
                        string toAdd = $"Dodan {cmbStudent.Invoke(()=> cmbStudent.Text)} -> {nastava.Oznaka}";
                        rtInfo.Text += $"{toAdd}\n";
                    });
                    dbContext.SaveChanges();
                }
            });

            MessageBox.Show("Gotovo generisanje");
            SetSource();

        }
    }
}
