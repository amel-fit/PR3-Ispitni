using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data._2202IB230046
{
    [Table("ProstorijeIB230046")]
    public class Prostorija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }
        public byte[] Logo { get; set; }
        public int Kapacitet { get; set; }

        [NotMapped]
        public Image LogoIMG {  get; set; }
        [NotMapped] public int BrPredmeta { get; set; }
        public virtual List<Nastava> Nastave { get; set; }
        
    }
}
