using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IB200002
{
    public class dtoKorisnik
    {
        public string ImePrezime { get; set; }
        public virtual List<KorisniciPoruke> ListaPoruka { get; set; } = new List<KorisniciPoruke>();
    }
}
