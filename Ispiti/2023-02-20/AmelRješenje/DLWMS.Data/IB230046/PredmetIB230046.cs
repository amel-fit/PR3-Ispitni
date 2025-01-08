using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230046
{
    [Table("Predmeti")]
    public class PredmetIB230046
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public PredmetIB230046(int id, string naziv)
        {
            Id = id;
            Naziv = naziv;
        }
        public override string ToString()
        {
            return Naziv;
        }
        public List<StudentiPredmetiIB230046> StudentiPredmeti { get; set; }
        public List<StudentiPorukeIB230046> studentiPoruke { get; set; }
    }
}
