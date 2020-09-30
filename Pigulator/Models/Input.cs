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
        
        
        //[Required(ErrorMessage = "Please select how many people are participating")]
        public int Customers { get; set; }


        
        //[Required(ErrorMessage = "Please select an amount")]
        public int Amount { get; set; }        
        
        
        //[Required(ErrorMessage = "Please Select which type of pork you are buy")]
        public bool WholeorHalf { get; set; }
    }
}
