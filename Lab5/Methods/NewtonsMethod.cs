using Lab1Fix.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab1Fix
{
    internal class NewtonsMethod
    {
        public List<Point> Solve(double x0, IEquation eq, double epsilon)
        {
            double x = x0;
            List<Point> Points = new List<Point>(); 

            while (Math.Abs(eq.Calculate(x)) >= epsilon)
            {
                x = x - eq.Calculate(x) / eq.CalculateDeriv(x);
                Points.Add(new Point(x, eq.Calculate(x)));
            }

            return Points;
        }
    }
}
