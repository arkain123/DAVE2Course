using Lab1Fix.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1Fix
{
    internal class IterativeMethod: AbstractMethod
    {
        public override List<Point> Solve(double x0, IEquation eq, double epsilon)
        {
            double x = x0;
            int iter = 0;
            List<Point> Points = new List<Point>();
            Points.Add(new Point(x, eq.Calculate(x)));

            while (Math.Abs(eq.Calculate(x)) > epsilon && iter < 1000)
            {
                iter++;
                double xnew = x - eq.Calculate(x) / eq.CalculateDeriv(x);
                if (Math.Abs(xnew - x) < epsilon) return Points;
                x = xnew;
                Points.Add(new Point(x, eq.Calculate(x)));
            }

            return Points;
        }
    }
}
