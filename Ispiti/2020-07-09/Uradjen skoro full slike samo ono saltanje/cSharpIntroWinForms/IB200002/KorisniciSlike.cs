using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IB200002
{
    [Table("KorisniciSlike")]
    public class KorisniciSlike
    {
        public int ID { get; set; }
        public Korisnik Korisnik { get; set; }
        public Slika Slika { get; set; }
    }
}
