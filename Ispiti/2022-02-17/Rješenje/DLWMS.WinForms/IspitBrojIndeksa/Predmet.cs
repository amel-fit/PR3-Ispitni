using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.WinForms.IspitBrojIndeksa
{
    [Table("Predmeti")]
    public class Predmet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}
