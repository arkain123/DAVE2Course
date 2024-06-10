using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Schema;

namespace Lab7
{
    internal class Graphic
    {
        private Chart igchart;
        private DataGridView dg;
        private List<(double x, double y)> points;

        public Chart IgChart
        {
            get { return igchart; }
            set { igchart = value; }
        }

        public DataGridView Dg
        {
            get { return dg; }
            set { dg = value; }
        }

        public List<(double x, double y)> Points
        {
            get { return points; }
            set { points = value; }
        }

        public Graphic(List<(double x, double y)> results, Chart ch)
        {
            IgChart = ch;
            Points = results;
        }

        private void Add(double x, double y)
        {
            IgChart.Series[0].Points.AddXY(x, y);
        }

        public void Clear()
        {
            IgChart.Series[0].Points.Clear();
        }

        public void Visualize()
        {
            Clear();
            foreach ((double x, double y) ipoint in Points)
            {
                Add(ipoint.x, ipoint.y);
            }
        }
    }
}
