using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab3
{
    internal class Drawing
    {
        public Equation igequeation;

        private Series igspline;

        private Series igsquare;

        public Series IgSpline
        {
            set
            {
                igspline = value;
            }

            get
            {
                return igspline;
            }
        }

        public Series IgSquare
        {
            set
            {
                igsquare = value;
            }

            get
            {
                return igsquare;
            }
        }

        public Equation IgEqueation
        {
            set
            {
                igequeation = value;
            }

            get
            {
                return igequeation;
            }
        }

        private void ChartAdd(double x, double y)
        {
            igsquare.Points.AddXY(x, y);
            igspline.Points.AddXY(x, y);
        }
        
        public void ChartClear()
        {
            igsquare.Points.Clear();
            igspline.Points.Clear();
        }

        public void DrawingTMethod() //метод трапеции
        {
            ChartClear();
            foreach (Point point in igequeation.Points)
            {
                ChartAdd(point.X, point.Y);
            }
        }
    }
}
