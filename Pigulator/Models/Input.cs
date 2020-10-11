
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Pigulator.Models
{
    public class Input
    {
       IEnumerable<Pigulator.Models.Pigs> pigs;
        public Input()
        {
            
            whole = pigs.WholePig;
            half = 1;
        }

        //[Required(ErrorMessage = "Please select how many people are participating")]
        public int Customers { get; set; }

        //[Required(ErrorMessage = "Please select an amount")]
        public int Amount { get; set; }

        //[Required(ErrorMessage = "Please Select which type of pork you are buy")]
        public bool WholeorHalf { get; set; }

        public decimal whole { get; set; }

        public decimal half { get; set; }
    }
}
