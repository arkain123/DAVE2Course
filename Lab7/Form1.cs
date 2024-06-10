using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab7
{
    public partial class Form1 : Form
    {
        private IEquation eq = new ThirdEquation();
        private Solver solv = new DynamicArraySolver(1, 2, 0.1, 1, new ThirdEquation());
        private List<(double x, double y)> points = new List<(double x, double y)>();

        public Form1()
        {
            InitializeComponent();
            dataGridView.RowHeadersVisible = false;
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            Graphic graph = new Graphic(points, chart1);
            DataGrid table = new DataGrid(points, dataGridView);
            table.Visualize();
            graph.Visualize();
        }

        private void firstEqRButton_CheckedChanged(object sender, EventArgs e)
        {
            eq = new FirstEquation();
        }

        private void secondEqRButton_CheckedChanged(object sender, EventArgs e)
        {
            eq = new SecondEquation();
        }

        private void thirdEqRButton_CheckedChanged(object sender, EventArgs e)
        {
            eq = new ThirdEquation();
        }

        private void StringListRButton_CheckedChanged(object sender, EventArgs e)
        {
            solv = new StringListSolver(
                    double.Parse(LBtextBox.Text),
                    double.Parse(UBtextBox.Text),
                    double.Parse(SteptextBox.Text),
                    double.Parse(y0textBox.Text),
                    eq
                    );
        }

        private void DynamicArrRButton_CheckedChanged(object sender, EventArgs e)
        {
            solv = new DynamicArraySolver(
                    double.Parse(LBtextBox.Text),
                    double.Parse(UBtextBox.Text),
                    double.Parse(SteptextBox.Text),
                    double.Parse(y0textBox.Text),
                    eq
                    );
        }

        private void eulerRButton_CheckedChanged(object sender, EventArgs e)
        {
            points = solv.SolveByEuler();
        }

        private void trapezoidalRButton_CheckedChanged(object sender, EventArgs e)
        {
            points = solv.SolveByTrapezoidal();
        }

        private void rungeKutta3RButton_CheckedChanged(object sender, EventArgs e)
        {
            points = solv.SolveByRungeKutta3();
        }

        private void rungeKutta4RButton_CheckedChanged(object sender, EventArgs e)
        {
            points = solv.SolveByRungeKutta4();
        }
    }
}
