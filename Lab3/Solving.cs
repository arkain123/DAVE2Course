using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab3
{
    class Equation
    {
        private double uBorder = 1;
        private double lBorder = 0;
        private double step = 0.01;
        private List<Point> points = new List<Point>();

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

        public List<Point> Points
        {
            get
            {
                return points;
            }
            set
            {
                points = value;
            }
        }

        public double SolveEq(double x)
        {
            return Math.Pow(Math.E, (-2 * Math.Pow(x, 2))) / (1 + Math.Sin(x));
        }

        public void SolvingTMethod() //метод трапеции
        {
            points.Clear();
            for (double x = lBorder; x <= uBorder; x += step)
            {
                double y = 0.5 * step * (SolveEq(x) + SolveEq(x + step));
                Point npoint = new Point(x, y);
                points.Add(npoint);
            }
        }

        public double GetResult()
        {
            double result = 0;
            foreach (Point point in points)
            {
                result += point.Y;
            }
            return result;
        }

        public void FindIntersection(Equation equation)
        {
            List<Point> Points1 = new List<Point>(points);
            List<Point> Points2 = new List<Point>(equation.points);
            points.Clear();
            const double EPS = 0.001;
            foreach (Point point1 in Points1)
            {
                foreach (Point point2 in Points2)
                {
                    if (Math.Abs(point2.Y - point1.Y) < EPS && Math.Abs(point2.X - point1.X) < EPS)
                    {
                        points.Add(new Point(point1.X, point2.Y));
                    }
                }
            }
        }

    }
}