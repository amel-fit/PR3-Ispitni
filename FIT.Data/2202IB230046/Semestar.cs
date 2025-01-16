using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data._2202IB230046
{
    [Table("Semestri")]
    public class Semestar
    {
        public int Id { get; set; }
        public string Oznaka { get; set; }
        public string Opis { get; set; }
        public bool Aktivan { get; set; }

        public virtual List<Predmet> Predmeti { get; set; }

    }
}
