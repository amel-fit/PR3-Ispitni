using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data._2202IB230046
{
    [Table("NastavaIB230046")]
    public class Nastava
    {
        public int Id { get; set; }
        public int ProstorijaId { get; set; }
        public int PredmetId { get; set; }
        public string VrijemeOdrzavanja { get; set; }
        public string Dan {  get; set; }
        public string Oznaka { get; set; }



        public virtual List<Prisustvo> Prisustva { get; set; }
        public virtual Prostorija Prostorija { get; set; }
        public virtual Predmet Predmet { get; set; }

        [NotMapped]
        public string PredmetTXT { get; set; }

    }
}
