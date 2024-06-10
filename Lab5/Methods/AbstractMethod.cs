using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Fix.Methods
{
    internal abstract class AbstractMethod
    {
        public virtual List<Point> Solve(double a, double b, IEquation eq, double epsilon)
        {
            return new List<Point>();
        }

        public virtual List<Point> Solve(double x0, IEquation eq, double epsilon)
        {
            return new List<Point>();
        }
    }
}
