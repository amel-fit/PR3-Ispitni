using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230046
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmetiIB230046
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }

        public PredmetIB230046 Predmet { get; set; }
        public Student Student { get; set; }

    }
}
