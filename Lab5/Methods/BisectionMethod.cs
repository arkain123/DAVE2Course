using Lab1Fix.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Fix
{
    internal class BisectionMethod: AbstractMethod
    {
        public override List<Point> Solve(double a, double b, IEquation eq, double epsilon)
        {
            double c = (a + b) / 2;

            List<Point> Points = new List<Point>();

            if (eq.Calculate(a) * eq.Calculate(b) >= 0)
            {
                Points.Add(new Point(0, eq.Calculate(0)));
                return Points;
            }

            while ((b - a) >= 2 * epsilon)
            {
                c = (a + b) / 2;
                Points.Add(new Point(c, eq.Calculate(c)));

                if (eq.Calculate(c) == 0)
                {
                    return Points;
                }
                else if (eq.Calculate(a) * eq.Calculate(c) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
            }

            return Points;
        }
    }
}
