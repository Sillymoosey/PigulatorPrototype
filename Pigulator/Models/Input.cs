using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pigulator.Models
{
    public class Input
    {
        

        [Range(1, 5)]
        [Required]
        public int Customers { get; set; }



        [Range(1, 5)]
        [Required]
        public int Amount { get; set; }        
        
        
        
        [Required]
        public bool WholeorHalf { get; set; }
    }
}
