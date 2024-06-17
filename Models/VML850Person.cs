using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VMLbaithi2324.Models
{
    [Table("VML850Person")]
    public class VML850Person
    {
        [Key]
        public int VML850ID { get; set;}
        public string VML850Name { get; set; }
        public double VML850SoThich { get; set; }
    }
}