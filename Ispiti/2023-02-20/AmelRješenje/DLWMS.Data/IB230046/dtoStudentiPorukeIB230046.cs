using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230046
{
    public class dtoStudentiPorukeIB230046
    {
        /*
         * Predmet
         * Sadrzaj
         * Slika
         * Validnost
         * [Brisi]
        */
        public string NazivPredmeta {  get; set; }
        public string Sadrzaj { get; set; }
        public Image Slika { get; set; }
        public DateTime Validnost { get; set; }

        public dtoStudentiPorukeIB230046(PredmetIB230046 p, string sadrzaj, byte[] slika, DateTime validnost)
        {
            NazivPredmeta = p.Naziv;
            Sadrzaj = sadrzaj;
            Slika = Image.FromStream(new MemoryStream(slika));
            Validnost = validnost;
        }

    }
}
