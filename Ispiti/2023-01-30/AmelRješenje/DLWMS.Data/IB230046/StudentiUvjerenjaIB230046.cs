using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.IB230046
{
    public class StudentiUvjerenjaIB230046
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime VrijemeKreiranja { get; set; }
        public string Vrsta { get; set; }
        public string Svrha { get; set; }
        public byte[] Uplatnica { get; set; }
        public bool Printano { get; set; }
        [NotMapped]
        public Image UplatnicaIMG { get => Image.FromStream(new MemoryStream(Uplatnica)); }
        public virtual Student Student { get; set; }
    }
}
