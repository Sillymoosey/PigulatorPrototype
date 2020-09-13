using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Pigulator
{
    public class PigulatorCore
    {
        private static double wholePig = 1450;
        private static double halfPig = 800;

        public static double WPigs(double pigs, double customer) => (pigs * wholePig)/customer;
        public static double HPigs(double pigs, double customer) => (pigs * halfPig) / customer;
        
    }
}
