using System;
using System.Windows.Forms;

namespace Lab1Fix
{
    public partial class Form1 : Form
    {
        readonly Equation igequation;
        readonly Drawing draw;

        public Form1()
        {
            InitializeComponent();
            igequation = new Equation
            {
                UBorder = 1,
                LBorder = 0,
                Step = 0.01
            };
            draw = new Drawing
            {
                IgChart = chart,
                IgEqueation = igequation
            };
            ResultLabel.Text = igequation.SolvingTMethod().ToString();
            draw.DrawingTMethod();
        }

        private void GetValues()
        {
            igequation.UBorder = Convert.ToDouble(UBorderTextBox.Text);
            igequation.LBorder = Convert.ToDouble(LBorderTextBox.Text);
            igequation.Step = Convert.ToDouble(StepTextBox.Text);
        }

        private void TMethodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GetValues();
            ResultLabel.Text = igequation.SolvingTMethod().ToString();
            draw.DrawingTMethod();
        }

        private void LRMethodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GetValues();
            ResultLabel.Text = igequation.SolvingLRMethod().ToString();
            draw.DrawingLRMethod();
        }

        private void RRMethodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GetValues();
            ResultLabel.Text = igequation.SolvingRRMethod().ToString();
            draw.DrawingRRMethod();
        }

        private void MRMethodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GetValues();
            ResultLabel.Text = igequation.SolvingMRMethod().ToString();
            draw.DrawingMRMethod();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
