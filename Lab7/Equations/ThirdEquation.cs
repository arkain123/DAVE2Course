﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class ThirdEquation : IEquation
    {
        public double Calculate(double x, double y)
        {
            return Math.Sin(x) * y;
        }
    }
}
