using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data._2202IB230046
{
    [Table("PrisustvoIB230046")]
    public class Prisustvo
    {
        public int Id { get; set; }
        public int NastavaId { get; set; }
        public int StudentId { get; set; }  

        public virtual Student Student { get; set; }
        public virtual Nastava Nastava { get; set; }

        [NotMapped]
        public string StudentTXT { get; set; }
        [NotMapped]
        public string OznakaTXT { get; set; }
    }
}
