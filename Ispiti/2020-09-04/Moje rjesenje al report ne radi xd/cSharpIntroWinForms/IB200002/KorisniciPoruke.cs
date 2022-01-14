using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace cSharpIntroWinForms.IB200002
{
    [Table("KorisniciPoruke")]
    public class KorisniciPoruke
    {
        public int ID { get; set; }
        public Korisnik Korisnik { get; set; }
        public string Poruka { get; set; }
        public DateTime Datum { get; set; }
        public byte[] Slika { get; set; }
    }
}
