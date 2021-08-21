using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB180207
{
    [Table("StudentiCovidTestovi")]
    public class StudentiCovidTestovi
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public string Rezultat { get; set; }
        public bool NalazDostavljen { get; set; }
    }
}
