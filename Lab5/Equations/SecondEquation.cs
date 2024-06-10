using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Fix
{
    internal class SecondEquation: IEquation
    {
        public double Calculate(double x)
        {
            return 0.5 * Math.Pow(x, 2) - 1;
        }

        public double CalculateDeriv(double x)
        {
            return x;
        }
    }
}
