using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.WinForms.IspitBrojIndeksa
{
    [Table("StudentiKonsultacije")]
    public class StudentKonsultacija
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual Predmet Predmet { get; set; }
        public DateTime VrijemeOdrzavanja { get; set; }
        public string Napomena { get; set; }
    }
}
