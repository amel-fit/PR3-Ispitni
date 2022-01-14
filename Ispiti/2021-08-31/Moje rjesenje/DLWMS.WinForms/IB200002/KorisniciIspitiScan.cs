using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB200002
{
    [Table("KorisniciIspitiScan")]
    public class KorisniciIspitiScan
    {
        public int ID { get; set; }
        public virtual Student Student{ get; set; }
        public virtual Predmet Predmet { get; set; }
        public string Napomena { get; set; }
        public byte[] SkeniranIspit { get; set; }
        public bool Varanje { get; set; }
    }
}
