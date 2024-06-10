using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Fix
{
    internal class FirstEquation: IEquation
    {
        public double Calculate(double x)
        {
            if (x <= 0)
            {
                return double.NaN;
            }

            return Math.Log(x) - 8;
        }

        public double CalculateDeriv(double x)
        {
            return 1 / x;
        }
    }
}
