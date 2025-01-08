using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230046
{
    public class dtoStudentPredmetIB230046
    {
        public string BrojIndeksa { get; set; }
        public string ImePrezime { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }

        public Student student { get; set; }
        public PredmetIB230046 predmet { get; set; }

        public dtoStudentPredmetIB230046(Student s, PredmetIB230046 p, StudentiPredmetiIB230046 sp)
        {
            student = s;
            predmet = p;

            BrojIndeksa = s.BrojIndeksa;
            ImePrezime = $"{s.Ime} {s.Prezime}";

            Ocjena = sp.Ocjena; 
            Datum = sp.Datum;

        }
    }
}
