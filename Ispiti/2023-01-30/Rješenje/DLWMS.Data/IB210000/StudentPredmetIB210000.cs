using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB210000
{
    [Table("StudentiPredmeti")]
    public class StudentPredmetIB210000
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public PredmetIB210000 Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
    }
}
