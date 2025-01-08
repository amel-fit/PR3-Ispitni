using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public int Id { get; set; }
        public string NazivPredmeta {  get; set; }
        public string Sadrzaj { get; set; }
        public Image Slika { get; set; }
        public DateTime Validnost { get; set; }

        public dtoStudentiPorukeIB230046(StudentiPorukeIB230046 sp)
        {
            Id = sp.Id;
            NazivPredmeta = sp.Predmet.Naziv;
            Sadrzaj = sp.Sadrzaj;
            Slika = Image.FromStream(new MemoryStream(sp.Slika));
            Validnost = sp.Validnost;
        }

    }
}
