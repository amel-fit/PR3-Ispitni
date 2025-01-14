using DLWMS.Data;
using DLWMS.Data.IB230046;
using DLWMS.WinForms.Helpers;
using System.Data;

namespace DLWMS.WinForms.IB230046
{
    public partial class frmUvjerenjaIB230046 : Form
    {
        DLWMSDbContext db = new();
        public Student Student { get; set; }
        public frmUvjerenjaIB230046(Student s)
        {
            InitializeComponent();
            dgvUvjerenja.AutoGenerateColumns = false;
            this.Student = s;
            SetSource();
            
        }

        private void SetSource()
        {
            var source = db.StudentiUvjerenjaIB230046.Where(su => su.StudentId == Student.Id).ToArray();
            dgvUvjerenja.DataSource = null;
            dgvUvjerenja.DataSource = source;
            this.Text = $"Broj uvjerenja -> {source.Count()}";
            
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            object? dgvRowItem = null;
            try { dgvRowItem = dgvUvjerenja.Rows[0].DataBoundItem; }
            catch { }
            if (dgvRowItem == null || !ValidneInformacije()) {
                return; 
            }
            await Task.Run(() =>
            {
                int brojZahtjeva = txtBroj.Invoke(() => int.Parse(txtBroj.Text));
                string svrha = txtSvrha.Invoke( () => txtSvrha.Text);
                string vrsta = cmbVrsta.Invoke(() => cmbVrsta.Text);
                var slika = (dgvRowItem as StudentiUvjerenjaIB230046).Uplatnica;
                for (int i = 0; i < brojZahtjeva; i++)
                {
                    var su = new StudentiUvjerenjaIB230046()
                    {
                        StudentId = Student.Id,
                        Printano = false,
                        Svrha = svrha,
                        Vrsta = vrsta,
                        Uplatnica =slika,
                        VrijemeKreiranja = DateTime.Now
                    };
                    db.StudentiUvjerenjaIB230046.Add(su);
                    richTextBox1.Invoke(() =>
                    {
                        string toAdd = string.Empty;
                        toAdd += $"{DateTime.Now.ToShortTimeString()} -> {vrsta} ({Student.BrojIndeksa}) - {Student.Ime} {Student.Prezime} u svrhu {svrha}\n";
                        richTextBox1.Text += toAdd;
                    });
                    Thread.Sleep(300);
                }
            });
            db.SaveChanges();
            MessageBox.Show("Dodavanje Završeno");
            SetSource();
        }

        private bool ValidneInformacije()
        {
            try
            {
                int.Parse(txtBroj.Text);
            }catch
            {
                Helpers.Validator.ValidirajKontrolu(txtBroj, err, Kljucevi.PodaciNisuValidni);
                return false;
            }
            return Helpers.Validator.ValidirajKontrolu(cmbVrsta, err, Kljucevi.PodaciNisuValidni)
                && Helpers.Validator.ValidirajKontrolu(txtSvrha, err, Kljucevi.ObaveznaVrijednost);
                
        }

        private void dgvUvjerenja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUvjerenja.Columns["Brisi"].Index)
            {
                //Brisi
                //MessageBox.Show("Brisi");
                var uvjerenje = dgvUvjerenja.Rows[e.RowIndex].DataBoundItem as StudentiUvjerenjaIB230046;
                db.StudentiUvjerenjaIB230046.Remove(uvjerenje);
                db.SaveChanges();
            }
            else if (e.ColumnIndex == dgvUvjerenja.Columns["Printaj"].Index)
            {
                //Printaj
                //MessageBox.Show("Printaj");
                var uvjerenje = dgvUvjerenja.Rows[e.RowIndex].DataBoundItem as StudentiUvjerenjaIB230046;
                uvjerenje.Printano = true;
            }
            SetSource();
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            new frmNovoUvjerenjeIB230046(Student).ShowDialog();
            SetSource();
        }
    }
}
