using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul
{
    public static class OneArgumentCalculatorFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "involution":
                    {
                        return new Involution();
                    }
                case "extract":
                    {
                        return new Extract();
                    }
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
