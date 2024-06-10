using Lab7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab7
{
    internal abstract class Solver
    {
        private double uBorder = 2;
        private double lBorder = 1;
        private double step = 0.1;
        private double y0 = 1;
        private IEquation eq;

        public double UBorder
        {
            get
            {
                return uBorder;
            }

            set
            {
                uBorder = value;
            }
        }

        public double LBorder
        {
            get
            {
                return lBorder;
            }

            set
            {
                lBorder = value;
            }
        }

        public double Step
        {
            get
            {
                return step;
            }

            set
            {
                step = value;
            }
        }
        
        public double Y0
        {
            get 
            {
                return y0;
            }

            set
            {
                y0 = value;
            }
        }

        public IEquation Eq
        {
            get
            {
                return eq;
            }

            set
            {
                eq = value;
            }
        }

        public Solver(double lB, double uB, double h, double iny0, IEquation ineq)
        {
            LBorder = lB;
            UBorder = uB;
            Step = h;
            Y0 = iny0;
            Eq = ineq;
        }

        public virtual List<(double x, double y)> SolveByEuler()
        {
            double x = LBorder, y = Y0;
            List<(double x, double y)> result = new List<(double x, double y)>();
            result.Add((x, y));
            while (x < UBorder)
            {
                y = EulerStep(x, y);
                result.Add((x, y));
                x += Step;
            }
            return result;
        }

        public virtual List<(double x, double y)> SolveByTrapezoidal()
        {
            double x = LBorder, y = Y0;
            List<(double x, double y)> result = new List<(double x, double y)>();
            result.Add((x, y));
            while (x < UBorder)
            {
                y = TrapezoidalStep(x, y);
                result.Add((x, y));
                x += Step;
            }
            return result;
        }

        public virtual List<(double x, double y)> SolveByRungeKutta3()
        {
            double x = LBorder, y = Y0;
            List<(double x, double y)> result = new List<(double x, double y)>();
            result.Add((x, y));
            while (x < UBorder)
            {
                y = RungeKutta3Step(x, y);
                result.Add((x, y));
                x += Step;
            }
            return result;
        }

        public virtual List<(double x, double y)> SolveByRungeKutta4()
        {
            double x = LBorder, y = Y0;
            List<(double x, double y)> result = new List<(double x, double y)>();
            result.Add((x, y));
            while (x < UBorder)
            {
                y = RungeKutta4Step(x, y);
                result.Add((x, y));
                x += Step;
            }
            return result;
        }

        protected double EulerStep(double x, double y)
        {
            return y + Step * eq.Calculate(x, y);
        }

        protected double TrapezoidalStep(double x, double y)
        {
            double y1 = y + Step * eq.Calculate(x, y);
            return y + Step / 2 * (eq.Calculate(x, y) + eq.Calculate(x + Step, y1));
        }

        protected double RungeKutta3Step(double x, double y)
        {
            double k1 = Step * eq.Calculate(x, y);
            double k2 = Step * eq.Calculate(x + Step / 2, y + k1 / 2);
            double k3 = Step * eq.Calculate(x + Step, y - k1 + 2 * k2);
            return y + (k1 + 4 * k2 + k3) / 6;
        }

        protected double RungeKutta4Step(double x, double y)
        {
            double k1 = Step * eq.Calculate(x, y);
            double k2 = Step * eq.Calculate(x + Step / 2, y + k1 / 2);
            double k3 = Step * eq.Calculate(x + Step / 2, y + k2 / 2);
            double k4 = Step * eq.Calculate(x + Step, y + k3);
            return y + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
        }
    }
}
