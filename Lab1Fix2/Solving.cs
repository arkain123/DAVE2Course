using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab1Fix
{
    class Equation
    {
        private double uBorder = 1;
        private double lBorder = 0;
        private double step = 0.01;

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

        public double SolveEq(double x)
        {
            return Math.Pow(Math.E, (-2 * Math.Pow(x, 2))) / (1 + Math.Sin(x));
        }

        public double SolvingTMethod() //метод трапеции
        {
            double result = 0;
            for (double x = lBorder; x <= uBorder; x += step)
            {
                result += 0.5 * step * (SolveEq(x) + SolveEq(x + step));
            }
            return result;

        }

        public double SolvingLRMethod() //метод левых пр.
        {
            double result = 0;
            for (double x = lBorder; x <= uBorder - step; x += step)
            {
                result += SolveEq(x) * step;
            }
            return result;
        }

        public double SolvingRRMethod() //метод правых пр.
        {
            double result = 0;
            for (double x = lBorder + step; x <= uBorder + step; x += step)
            {
                result += SolveEq(x) * step;
            }
            return result;

        }

        public double SolvingMRMethod() //метод средних пр.
        {
            double result = 0;
            for (double x = lBorder + step / 2; x <= uBorder; x += step)
            {
                result += SolveEq(x) * step;
            }
            return result;
        }
    }

    internal class Drawing
    {
        public Equation igequeation;

        private Chart igchart;

        public Chart IgChart
        {
            set
            {
                igchart = value;
            }
        }

        public Equation IgEqueation
        {
            set
            {
                igequeation = value;
            }
        }

        private void ChartAdd(double x, double y)
        {
            igchart.Series[1].Points.AddXY(x, y);
            igchart.Series[0].Points.AddXY(x, y);
        }

        public void ChartClear()
        {
            igchart.Series[0].Points.Clear();
            igchart.Series[1].Points.Clear();
        }

        public void DrawingTMethod() //метод трапеции
        {
            ChartClear();
            for (double x = igequeation.LBorder; x <= igequeation.UBorder; x += igequeation.Step)
            {
                double y = 0.5 * igequeation.Step * (igequeation.SolveEq(x) + igequeation.SolveEq(x + igequeation.Step));
                ChartAdd(x, y);
            }
        }

        public void DrawingLRMethod() //метод левых пр.
        {
            ChartClear();
            for (double x = igequeation.LBorder; x <= igequeation.UBorder; x += igequeation.Step)
            {
                double y = igequeation.SolveEq(x) * igequeation.Step;
                ChartAdd(x, y);
            }
        }

        public void DrawingRRMethod() //метод правых пр.
        {
            ChartClear();
            for (double x = igequeation.LBorder + igequeation.Step; x <= igequeation.UBorder + igequeation.Step; x += igequeation.Step)
            {
                double y = igequeation.SolveEq(x) * igequeation.Step;
                ChartAdd(x, y);
            }
        }

        public void DrawingMRMethod() //метод средних пр.
        {
            ChartClear();
            for (double x = igequeation.LBorder + igequeation.Step / 2; x <= igequeation.UBorder; x += igequeation.Step)
            {
                double y = igequeation.SolveEq(x) * igequeation.Step;
                ChartAdd(x, y);
            }
        }
    }
}
