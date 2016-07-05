using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul
{
    public static class TwoArgumentCalculatorFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "addition":
                    {
                        return new Addition();
                    }
                case "subtraction":
                    {
                        return new Subtraction();
                    }
                case "multiplication":
                    {
                        return new Multiplication();
                    }
                case "division":
                    {
                        return new Division();
                    }
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
