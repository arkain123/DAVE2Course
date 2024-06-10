using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Schema;

namespace Lab1Fix
{
    internal class Graphic
    {
        private Chart igchart;

        public Chart IgChart
        {
            set
            {
                igchart = value;
            }

            get
            {
                return igchart;
            }
        }

        public Graphic(Chart ch) 
        {
            igchart = ch;
        }

        private void ChartAdd(double x, double y, int num)
        {
            IgChart.Series[0].Points.AddXY(x, y);
            IgChart.Series[0].Points[IgChart.Series[0].Points.Count-1].Label = num.ToString();
        }

        public void ChartClear()
        {
            IgChart.Series[0].Points.Clear();
        }

        public void VisualizeBisectionMethod(List<Point> Points)
        {
            int num = 0;
            ChartClear();
            foreach (Point ipoint in Points) 
            {
                num++;
                ChartAdd(ipoint.X, ipoint.Y, num);
            }
        }

        public void VisualizeIterativeMethod(List<Point> Points)
        {
            int num = 0;
            ChartClear();
            foreach (Point ipoint in Points)
            {
                num++;
                ChartAdd(ipoint.X, ipoint.Y, num);
            }
        }

        public void VisualizeNewtonsMethod(List<Point> Points)
        {
            int num = 0;
            ChartClear();
            foreach (Point ipoint in Points)
            {
                num++;
                ChartAdd(ipoint.X, ipoint.Y, num);
            }
        }
    }
}
