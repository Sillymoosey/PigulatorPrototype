using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Pigulator.Models;
using Pigulator.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace Pigulator
{
    public class PigulatorCore
    {

        public static double WPigs(double pigs, double customer, decimal wholePig) => (pigs * Convert.ToDouble(wholePig)) /customer;
        public static double HPigs(double pigs, double customer, decimal halfPig) => (pigs * Convert.ToDouble(halfPig)) / customer;
        
    }
}
