using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230046
{
    public class StudentiPredmeti
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
        public virtual Student Student { get; set; }
        public virtual Predmet Predmet { get; set; }
    }
}
