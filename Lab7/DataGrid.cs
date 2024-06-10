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
    internal class DataGrid
    {
        private DataGridView dgv;
        private List<(double x, double y)> points;

        public DataGridView Dgv
        {
            get { return dgv; }
            set { dgv = value; }
        }

        public List<(double x, double y)> Points
        {
            get { return points; }
            set { points = value; }
        }

        public DataGrid(List<(double x, double y)> results, DataGridView datagrid)
        {
            Dgv = datagrid;
            Points = results;
        }

        private void Add(double x, double y)
        {
            Dgv.Rows.Add(x, y);
        }

        public void Clear()
        {
            Dgv.Rows.Clear();
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
