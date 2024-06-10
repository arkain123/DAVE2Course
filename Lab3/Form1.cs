using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab3
{
    public partial class Form1 : Form
    {

        readonly Equation first_equation;
        readonly Equation second_equation;
        readonly Drawing first_draw;
        readonly Drawing second_draw;
        readonly Drawing gen_draw;

        public Form1()
        {
            InitializeComponent();
            first_equation = new Equation
            {
                UBorder = 1,
                LBorder = 0,
                Step = 0.01
            };
            first_draw = new Drawing
            {
                IgSpline = chart.Series[0],
                IgSquare = chart.Series[2],
                IgEqueation = first_equation
            };

            second_equation = new Equation
            {
                UBorder = 1,
                LBorder = 0,
                Step = 0.01
            };
            second_draw = new Drawing
            {
                IgSpline = chart.Series[1],
                IgSquare = chart.Series[3],
                IgEqueation = second_equation
            };
            gen_draw = new Drawing
            {
                IgSpline = chart.Series[5],
                IgSquare = chart.Series[4],
                IgEqueation = first_equation
            };

            first_equation.SolvingTMethod();
            second_equation.SolvingTMethod();
            first_draw.DrawingTMethod();
            second_draw.DrawingTMethod();
        }

        private void GetValues()
        {
            first_equation.UBorder = Convert.ToDouble(ulimit1tBox.Text);
            first_equation.LBorder = Convert.ToDouble(llimit1tBox.Text);
            first_equation.Step = Convert.ToDouble(step1tBox.Text);

            second_equation.UBorder = Convert.ToDouble(ulimit2tBox.Text);
            second_equation.LBorder = Convert.ToDouble(llimit2tBox.Text);
            second_equation.Step = Convert.ToDouble(step2tBox.Text);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            first_draw.ChartClear();
            second_draw.ChartClear();
            gen_draw.ChartClear();
            result1tBox.Text = "";
            result2tBox.Text = "";
            difftBox.Text = "";
            sumtBox.Text = "";
        }

        private void chartButton1_Click(object sender, EventArgs e)
        {
            ColorPicker(chart.Series[0], linecolor1cBox.Text);
            ColorPicker(chart.Series[2], fillcolor1cBox.Text);
            first_draw.DrawingTMethod();
        }

        private void chartButton2_Click(object sender, EventArgs e)
        {
            ColorPicker(chart.Series[1], linecolor2cBox.Text);
            ColorPicker(chart.Series[3], fillcolor2cBox.Text);
            second_draw.DrawingTMethod();
        }

        private void solveButton1_Click(object sender, EventArgs e)
        {
            GetValues();
            first_equation.SolvingTMethod();
            result1tBox.Text = first_equation.GetResult().ToString();
        }

        private void solveButton2_Click(object sender, EventArgs e)
        {
            GetValues();
            second_equation.SolvingTMethod();
            result2tBox.Text = second_equation.GetResult().ToString();
        }

        private void ColorPicker(Series serie, string color)
        {
            switch (color)
            {
                case "Red":
                    serie.Color = Color.Red;
                    break;
                case "Green":
                    serie.Color = Color.Green;
                    break;
                case "Blue":
                    serie.Color = Color.Blue;
                    break;
                case "Yellow":
                    serie.Color = Color.Yellow;
                    break;
                case "Purple":
                    serie.Color = Color.Purple;
                    break;
                case "Orange":
                    serie.Color = Color.Orange;
                    break;
                default:
                    serie.Color = Color.Red;
                    break;
            };
        }

        private void genareaButton_Click(object sender, EventArgs e)
        {
            GetValues();
            ColorPicker(chart.Series[4], genareacBox.Text);
            ColorPicker(chart.Series[5], genareacBox.Text);
            first_equation.FindIntersection(second_equation);
            gen_draw.DrawingTMethod();
        }

        private void diffButton_Click(object sender, EventArgs e)
        {
            GetValues();
            first_equation.SolvingTMethod();
            second_equation.SolvingTMethod();
            double diff = first_equation.GetResult() - second_equation.GetResult();
            difftBox.Text = diff.ToString();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            GetValues();
            first_equation.SolvingTMethod();
            second_equation.SolvingTMethod();
            double sum = first_equation.GetResult() + second_equation.GetResult();
            sumtBox.Text = sum.ToString();
        }
    }
}
