using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using DLWMS.WinForms.DB;

namespace DLWMS.WinForms.IspitBrojIndeksa
{
    [Table("StudentiPredmeti")]
    public class StudentPredmet
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual Predmet Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
    }
}
