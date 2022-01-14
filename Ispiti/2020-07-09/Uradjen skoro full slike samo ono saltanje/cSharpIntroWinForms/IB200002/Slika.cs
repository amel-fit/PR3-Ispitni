using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IB200002
{
    [Table("Slika")]
    public class Slika
    {
        public int ID { get; set; }
        public byte[] NizByteovaSlike { get; set; }
    }
}
