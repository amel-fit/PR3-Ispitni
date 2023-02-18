using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB210000
{
    public class dtoStudentIB210000
    {
        DLWMSDbContext db=KonekcijaIB210000.db;
        public Student Student { get; set; }
        public string Indeks => Student.BrojIndeksa;
        public string ImePrezime => Student.Ime + " "+Student.Prezime;
        public DateTime DatumRodjenja => Student.DatumRodjenja;
        public string Prosjek => IzracunajProsjek();
        public bool Aktivan => Student.Aktivan;

        private string IzracunajProsjek()
        {
            DLWMSDbContext db = KonekcijaIB210000.db;
            return db.StudentiPredmeti.Include(x => x.Student)
                .Where(x => x.Student.Id == Student.Id).Average(x => x.Ocjena).ToString("0.00");
        }       
    }
}
