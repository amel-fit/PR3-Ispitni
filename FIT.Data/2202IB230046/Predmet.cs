using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data._2202IB230046
{
    [Table("Predmeti")]
    public class Predmet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Semestar { get; set; }


        public virtual Semestar SemestarObj { get; set; }
        public virtual List<Nastava> Nastave { get; set; }
    }
}
