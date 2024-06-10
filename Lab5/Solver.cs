using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Fix
{
    internal class Solver
    {
        private double uBorder = 1;
        private double lBorder = 0;
        private double step = 0.01;
        private Graphic chart;

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

        public Graphic Chart
        {
            set
            {
                chart = value;
            }

            get
            {
                return chart;
            }
        }

        public Solver(Graphic ch)
        {
            Chart = ch;
        }

        public List<Point> SolveByBisectionMethod(IEquation eq)
        {
            BisectionMethod bisectionMethod = new BisectionMethod();
            List<Point> Points = bisectionMethod.Solve(LBorder, UBorder, eq, Step);
            Chart.VisualizeBisectionMethod(Points);
            return Points;
        }

        public List<Point> SolveByIterativeMethod(IEquation eq)
        {
            IterativeMethod iterativeMethod = new IterativeMethod();
            List<Point> Points = iterativeMethod.Solve(LBorder, eq, Step);
            Chart.VisualizeIterativeMethod(Points);
            return Points;
        }

        public List<Point> SolveByNewtonsMethod(IEquation eq)
        {
            NewtonsMethod newtonsMethod = new NewtonsMethod();
            List<Point> Points = newtonsMethod.Solve(UBorder, eq, Step);
            
            return Points;
        }
    }
}
