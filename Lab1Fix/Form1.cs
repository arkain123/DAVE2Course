using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Fix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SomethingChanged();
        }

        private void TMethodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SomethingChanged();
        }

        private void LRMethodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SomethingChanged();
        }

        private void RRMethodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SomethingChanged();
        }

        private void MRMethodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SomethingChanged();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SomethingChanged()
        {
            Solving Equation = new Solving();
            GraphicChart MainChart = new GraphicChart();

            Equation.UBorder = UBorderTextBox.Text;
            Equation.LBorder = LBorderTextBox.Text;
            Equation.Step = StepTextBox.Text;
            MainChart.UBorder = UBorderTextBox.Text;
            MainChart.LBorder = LBorderTextBox.Text;
            MainChart.Step = StepTextBox.Text;

            if (TMethodRadioButton.Checked)
            {
                ResultLabel.Text = Equation.TMethod().ToString();
                MainChart.TMethod(chart);
            }
            if (RRMethodRadioButton.Checked)
            {
                ResultLabel.Text = Equation.RRMethod().ToString();
                MainChart.RRMethod(chart);
            }
            if (MRMethodRadioButton.Checked)
            {
                ResultLabel.Text = Equation.MRMethod().ToString();
                MainChart.MRMethod(chart);
            }
            if (LRMethodRadioButton.Checked)
            {
                ResultLabel.Text = Equation.LRMethod().ToString();
                MainChart.LRMethod(chart);
            }
        }
    }
}
