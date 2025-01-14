using DLWMS.Data.IB230046;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

namespace DLWMS.Data
{
    [Table("Studenti")]
    public class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojIndeksa { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int GodinaStudija { get; set; }
        public byte[] Slika { get; set; }
        public bool Aktivan { get; set; }
        public int SpolId { get; set; }

        public override string ToString()
        {
            return $"({BrojIndeksa}) - {Ime} {Prezime}";
        }

        public virtual Spol Spol { get; set; }       
        public virtual List<StudentiPredmeti> StudentiPredmeti { get; set; }
        public virtual List<StudentiUvjerenjaIB230046> StudentiUvjerenjaIB230046 { get; set; }
    }  
}