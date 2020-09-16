using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;



namespace Pigulator.Models
{
    public class Pigs
    {
        [Key]
        public long PigID { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal WholePig { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal HalfPig { get; set; }
    }
}
