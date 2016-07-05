using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul
{
    public class Extract : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}
