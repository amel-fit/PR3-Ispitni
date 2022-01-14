using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB200002
{
    [Table("StudentiCovidTestovi")]
    public class StudentiCovidTestovi
    {
        public int ID { get; set; }
        public Student Student { get; set; }
        public DateTime Datum { get; set; }
        public string Rezultat { get; set; }
        public string NalazDostavljen { get; set; }

    }
}
