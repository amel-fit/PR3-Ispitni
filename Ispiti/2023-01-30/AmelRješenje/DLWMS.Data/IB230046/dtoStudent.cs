using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230046
{
    public class dtoStudent
    {
        public string ImePrezime { get; set; }
        public string BrojIndeksa { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }
        public float Prosjek {  get; set; }
        
        public Student student { get; set; }
        public dtoStudent(Student s)
        {
            student = s;
            ImePrezime = $"{s.Ime} {s.Prezime}";
            BrojIndeksa = s.BrojIndeksa;
            DatumRodjenja = s.DatumRodjenja;
            Aktivan = s.Aktivan;
            Prosjek = getProsjek();
            

        }

        private float getProsjek()
        {
            float prosjek = 0;
            int counter = 0;
            DLWMSDbContext db = new DLWMSDbContext();
            var lstStudPred = db.StudentiPredmeti.Where(sp => sp.StudentId == student.Id).ToArray();
            foreach (var sp in lstStudPred) 
            {
                prosjek += sp.Ocjena;
                counter++;
            }

            return prosjek / MathF.Max(1, counter);
        }
    }
}
