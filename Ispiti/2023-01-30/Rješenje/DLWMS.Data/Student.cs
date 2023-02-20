using DLWMS.Data.IB210000;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

namespace DLWMS.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojIndeksa { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int GodinaStudija { get; set; }
        public byte[] Slika { get; set; }
        public bool Aktivan { get; set; }
        public Spol Spol { get; set; }

        //drugi nacin rjesavanja prvog zadatka je da se dodaju potrebni atributi u klasi
        //public string ImePrezime => Ime + " " + Prezime;
        //public string Prosjek => IzracunajProsjek();
        //private string IzracunajProsjek()
        //{
        //    DLWMSDbContext db = KonekcijaIB210000.db;
        //    return db.StudentiPredmeti.Include(x => x.Student)
        //        .Where(x => x.Student.Id == Id).Average(x => x.Ocjena).ToString("0.00");
        //}

        public override string ToString()
        {
            return $"({BrojIndeksa}) - {Ime} {Prezime}";
        }
    }  
}