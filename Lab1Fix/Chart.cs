using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab1Fix
{
    internal class GraphicChart
    {
        double uBorder = 1;
        double lBorder = 0;
        double step = 0.01;

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

        public void TMethod(Chart chart1)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            for (double x = lBorder; x <= uBorder; x += step)
            {
                double y = Solve(x) * step;
                chart1.Series[1].Points.AddXY(x, y);
                chart1.Series[0].Points.AddXY(x, y);
            }
        }

        public void LRMethod(Chart chart1)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            for (double x = lBorder; x <= uBorder; x += step)
            {
                double y = Solve(x) * step;
                chart1.Series[1].Points.AddXY(x, y);
                chart1.Series[0].Points.AddXY(x, y);
            }
        }

        public void RRMethod(Chart chart1)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            for (double x = lBorder + step; x <= uBorder + step; x += step)
            {
                double y = Solve(x) * step;
                chart1.Series[1].Points.AddXY(x, y);
                chart1.Series[0].Points.AddXY(x, y);
            }
        }

        public void MRMethod(Chart chart1)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            for (double x = lBorder + step / 2; x <= uBorder; x += step)
            {
                double y = Solve(x) * step;
                chart1.Series[1].Points.AddXY(x, y);
                chart1.Series[0].Points.AddXY(x, y);
            }
        }
    }
}
