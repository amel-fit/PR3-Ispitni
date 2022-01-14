using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IB200002
{
    public partial class KorisnikSlikePregled : Form
    {
        private Korisnik _odabrani;
        KonekcijaNaBazu _baza = DLWMS.DB;

        public KorisnikSlikePregled(Korisnik odabrani)
        {
            InitializeComponent();
            _odabrani = odabrani;
        }

        private void KorisnikSlikePregled_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageHelper.FromByteToImage(_odabrani.Slika);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                var novaSlika = new Slika
                {
                    NizByteovaSlike = ImageHelper.FromImageToByte(Image.FromFile(openFileDialog1.FileName)),
                };
                var noviKorisnik = new KorisniciSlike
                {
                    Slika = novaSlika,
                };
               
            }
        }
    }
}
