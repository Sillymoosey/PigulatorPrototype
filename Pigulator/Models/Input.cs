using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Pigulator.Data;

namespace Pigulator.Models
{
    public class Input
    {


        public Input()
        {
            whole = 1450.00M;
            half = 800.00M;
        }

        //IEnumerable<Input> price = Pigs.Select(pigPrice => new Input
        //{
        //    whole = pigPrice.WholePig,
        //    half = pigPrice.HalfPig
        //});

        [Required(ErrorMessage = "Please select how many people are participating")]
        public int Customers { get; set; }

        [Required(ErrorMessage = "Please select an amount")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Please Select which type of pork you are buy")]
        public bool WholeorHalf { get; set; }


        public decimal whole { get; set; }

        public decimal half { get; set; }

        [Required(ErrorMessage = "Please enter a Name")]
        public string Name { get; set; }
    }
}
