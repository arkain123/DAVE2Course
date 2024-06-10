using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class FirstEquation : IEquation
    {
        public double Calculate(double x, double y)
        {
            return (3 * x) - (2 * y) + 5;
        }
    }
}
