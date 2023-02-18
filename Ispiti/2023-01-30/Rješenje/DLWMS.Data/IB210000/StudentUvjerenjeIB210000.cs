using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB210000
{
    [Table("StudentiUvjerenja")]
    public class StudentUvjerenjeIB210000
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public string Vrsta { get; set; }
        public string Svrha { get; set; }
        public byte[] Uplatnica { get; set; }
        public bool Printano { get; set; }
        public DateTime Datum { get; set; }
    }
}
