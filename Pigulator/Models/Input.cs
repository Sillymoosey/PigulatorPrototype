using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pigulator.Models
{
    public class Input
    {
        [Required(ErrorMessage = "Please enter the number of customers.")]
        public int Customers { get; set; }
        [Required(ErrorMessage = "Enter the number of pigs that you want.")]
        public int Pigs { get; set; }
        [Required(ErrorMessage = "Please select whole or half.")]
        public bool WholeorHalf { get; set; }
        public int Amount { get; set; }
    }
}
