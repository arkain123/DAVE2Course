using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Fix
{
    internal class ThirdEquation: IEquation
    {
        public double Calculate(double x)
        {
            return 0.25 * Math.Pow(x, 3) + x - 1.25;
        }

        public double CalculateDeriv(double x)
        {
            return (3 * Math.Pow(x, 2)) / 4 + 1;
        }

        public double fi(double x)
        {
            return 1.25 - 0.25 * Math.Pow(x, 3);
        }
    }
}
