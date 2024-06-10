using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab1Fix
{
    public partial class Form1 : Form
    {
        readonly Graphic draw;
        readonly Solver solv;
        readonly FirstEquation feq;
        readonly SecondEquation seq;
        readonly ThirdEquation teq;

        public Form1()
        {
            feq = new FirstEquation();
            seq = new SecondEquation();
            teq = new ThirdEquation();

            InitializeComponent();
            draw = new Graphic(chart);
            solv = new Solver(draw);
            List<Point> Points = solv.SolveByBisectionMethod(seq);
            ResultLabel.Text = Points[Points.Count - 1].X.ToString();
        }

        private void GetValues()
        {
            solv.UBorder = Convert.ToDouble(UBorderTextBox.Text);
            solv.LBorder = Convert.ToDouble(LBorderTextBox.Text);
            solv.Step = Convert.ToDouble(StepTextBox.Text);
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            GetValues();
            ResultLabel.Text = CheckMethod(CheckEq()).ToString();
            CheckRounding();
        }

        private double CheckMethod(IEquation eq) {
            List<Point> Points;
            if (HalfDivisionButton.Checked)
            {
                Points = solv.SolveByBisectionMethod(eq);
                draw.VisualizeBisectionMethod(Points);
                return Points[Points.Count - 1].X;
            }
            else if (ItterationButton.Checked)
            {
                Points = solv.SolveByIterativeMethod(eq);
                draw.VisualizeIterativeMethod(Points);
                return Points[Points.Count - 1].X;
            }
            Points = solv.SolveByNewtonsMethod(eq);
            draw.VisualizeNewtonsMethod(Points);
            return Points[Points.Count - 1].X;
        }

        private IEquation CheckEq() {
            if (firstEqButton.Checked)
                return feq;
            else if (secondEqButton.Checked)
                return seq;
            else
                return teq;
        }

        private void CheckRounding()
        {
            if (interpolateCheckBox.Checked && ResultLabel.Text.Length > numericUDChars.Value) {
                ResultLabel.Text = ResultLabel.Text.Remove((int)numericUDChars.Value);
            }
        }

    }
}
