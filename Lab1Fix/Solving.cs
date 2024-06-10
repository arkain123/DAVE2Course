using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Fix
{
    internal class Solving
    {
        double uBorder;
        double lBorder;
        double step;

        public string UBorder
        {
            get
            {
                return uBorder.ToString();
            }

            set
            {
                double.TryParse(value, out uBorder);
            }
        }

        public string LBorder
        {
            get
            {
                return lBorder.ToString();
            }

            set
            {
                double.TryParse(value, out lBorder);
            }
        }

        public string Step
        {
            get
            {
                return step.ToString();
            }

            set
            {
                double.TryParse(value, out step);
            }
        }

        public double Solve(double x)
        {
            return Math.Pow(Math.E, (-2 * Math.Pow(x, 2))) / (1 + Math.Sin(x));
        }

        public double TMethod()
        {
            double result = 0;
            for (double x = lBorder; x <= uBorder; x += step)
            {
                result += 0.5 * step * (Solve(x) + Solve(x + step));
            }
            return result;
        }

        public double LRMethod()
        {
            double result = 0;
            for (double x = lBorder; x <= uBorder; x += step)
            {
                result += Solve(x) * step;
            }
            return result;
        }

        public double RRMethod()
        {
            double result = 0;
            for (double x = lBorder + step; x <= uBorder + step; x += step)
            {
                result += Solve(x) * step;
            }
            return result;
        }

        public double MRMethod()
        {
            double result = 0;
            for (double x = lBorder + step / 2; x <= uBorder; x += step)
            {
                result += Solve(x) * step;
            }
            return result;
        }
    }
}
