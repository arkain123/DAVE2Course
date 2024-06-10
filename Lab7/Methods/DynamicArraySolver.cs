using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class DynamicArraySolver : Solver, ISave
    {
        private List<object> results;

        public List<object> Result { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DynamicArraySolver(double lB, double uB, double h, double iny0, IEquation ineq)
        : base(lB, uB, h, iny0, ineq)
        {
            results = new List<object>();
        }

        public override List<(double x, double y)> SolveByEuler()
        {
            var data = base.SolveByRungeKutta3();
            foreach (var item in data)
            {
                AddData(item);
            }
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

        public override List<(double x, double y)> SolveByTrapezoidal()
        {
            var data = base.SolveByRungeKutta3();
            foreach (var item in data)
            {
                AddData(item);
            }
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

        public override List<(double x, double y)> SolveByRungeKutta3()
        {
            var data = base.SolveByRungeKutta3();
            foreach (var item in data)
            {
                AddData(item);
            }
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

        public override List<(double x, double y)> SolveByRungeKutta4()
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

        public List<object> GetResult()
        {
            return results;
        }

        public void AddData((double x, double y) item)
        {
            Result.Add(item);
        }
    }
}
