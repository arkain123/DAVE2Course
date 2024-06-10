using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Fix
{
    internal interface IEquation
    {
        double Calculate(double x);

        double CalculateDeriv(double x);
    }
}
