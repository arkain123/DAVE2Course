using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab1Fix
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.MethodGroupBox = new System.Windows.Forms.GroupBox();
            this.NewtonButton = new System.Windows.Forms.RadioButton();
            this.ItterationButton = new System.Windows.Forms.RadioButton();
            this.HalfDivisionButton = new System.Windows.Forms.RadioButton();
            this.SolveButton = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BordersGroupBox = new System.Windows.Forms.GroupBox();
            this.UBorderTextBox = new System.Windows.Forms.TextBox();
            this.LBorderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StepGroupBox = new System.Windows.Forms.GroupBox();
            this.StepTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.thirdEqButton = new System.Windows.Forms.RadioButton();
            this.secondEqButton = new System.Windows.Forms.RadioButton();
            this.firstEqButton = new System.Windows.Forms.RadioButton();
            this.interpolateCheckBox = new System.Windows.Forms.CheckBox();
            this.numericUDChars = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.MethodGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel1.SuspendLayout();
            this.BordersGroupBox.SuspendLayout();
            this.StepGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDChars)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MethodGroupBox
            // 
            this.MethodGroupBox.Controls.Add(this.NewtonButton);
            this.MethodGroupBox.Controls.Add(this.ItterationButton);
            this.MethodGroupBox.Controls.Add(this.HalfDivisionButton);
            this.MethodGroupBox.Location = new System.Drawing.Point(12, 11);
            this.MethodGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MethodGroupBox.Name = "MethodGroupBox";
            this.MethodGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MethodGroupBox.Size = new System.Drawing.Size(292, 110);
            this.MethodGroupBox.TabIndex = 1;
            this.MethodGroupBox.TabStop = false;
            this.MethodGroupBox.Text = "Метод нахождения";
            // 
            // NewtonButton
            // 
            this.NewtonButton.AutoSize = true;
            this.NewtonButton.Location = new System.Drawing.Point(23, 82);
            this.NewtonButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewtonButton.Name = "NewtonButton";
            this.NewtonButton.Size = new System.Drawing.Size(86, 20);
            this.NewtonButton.TabIndex = 2;
            this.NewtonButton.TabStop = true;
            this.NewtonButton.Text = "Ньютона";
            this.NewtonButton.UseVisualStyleBackColor = true;
            // 
            // ItterationButton
            // 
            this.ItterationButton.AutoSize = true;
            this.ItterationButton.Location = new System.Drawing.Point(23, 58);
            this.ItterationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItterationButton.Name = "ItterationButton";
            this.ItterationButton.Size = new System.Drawing.Size(93, 20);
            this.ItterationButton.TabIndex = 1;
            this.ItterationButton.TabStop = true;
            this.ItterationButton.Text = "Итераций";
            this.ItterationButton.UseVisualStyleBackColor = true;
            // 
            // HalfDivisionButton
            // 
            this.HalfDivisionButton.AutoSize = true;
            this.HalfDivisionButton.Checked = true;
            this.HalfDivisionButton.Location = new System.Drawing.Point(23, 34);
            this.HalfDivisionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HalfDivisionButton.Name = "HalfDivisionButton";
            this.HalfDivisionButton.Size = new System.Drawing.Size(174, 20);
            this.HalfDivisionButton.TabIndex = 0;
            this.HalfDivisionButton.TabStop = true;
            this.HalfDivisionButton.Text = "Половинного деления";
            this.HalfDivisionButton.UseVisualStyleBackColor = true;
            // 
            // SolveButton
            // 
            this.SolveButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.SolveButton.Location = new System.Drawing.Point(69, 351);
            this.SolveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(165, 49);
            this.SolveButton.TabIndex = 8;
            this.SolveButton.Text = "Рассчитать";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.PaleGoldenrod;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(16, -33);
            this.chart.Name = "chart";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.IndianRed;
            series1.Legend = "Legend1";
            series1.LegendText = "График";
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.MarkerBorderWidth = 2;
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Square";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValuesPerPoint = 4;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(499, 457);
            this.chart.TabIndex = 9;
            this.chart.Text = "chart1";
            title1.Name = "Вычисляемая площадь";
            title2.Name = "Функция";
            this.chart.Titles.Add(title1);
            this.chart.Titles.Add(title2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.chart);
            this.panel1.Location = new System.Drawing.Point(310, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 438);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Графическое изображение";
            // 
            // BordersGroupBox
            // 
            this.BordersGroupBox.Controls.Add(this.UBorderTextBox);
            this.BordersGroupBox.Controls.Add(this.LBorderTextBox);
            this.BordersGroupBox.Controls.Add(this.label1);
            this.BordersGroupBox.Location = new System.Drawing.Point(12, 126);
            this.BordersGroupBox.Name = "BordersGroupBox";
            this.BordersGroupBox.Size = new System.Drawing.Size(277, 56);
            this.BordersGroupBox.TabIndex = 11;
            this.BordersGroupBox.TabStop = false;
            this.BordersGroupBox.Text = "Промежуток";
            // 
            // UBorderTextBox
            // 
            this.UBorderTextBox.Location = new System.Drawing.Point(140, 25);
            this.UBorderTextBox.Name = "UBorderTextBox";
            this.UBorderTextBox.Size = new System.Drawing.Size(100, 22);
            this.UBorderTextBox.TabIndex = 1;
            this.UBorderTextBox.Text = "3";
            // 
            // LBorderTextBox
            // 
            this.LBorderTextBox.Location = new System.Drawing.Point(15, 24);
            this.LBorderTextBox.Name = "LBorderTextBox";
            this.LBorderTextBox.Size = new System.Drawing.Size(100, 22);
            this.LBorderTextBox.TabIndex = 0;
            this.LBorderTextBox.Text = "0,5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "[                ,                 ]";
            // 
            // StepGroupBox
            // 
            this.StepGroupBox.Controls.Add(this.StepTextBox);
            this.StepGroupBox.Location = new System.Drawing.Point(12, 188);
            this.StepGroupBox.Name = "StepGroupBox";
            this.StepGroupBox.Size = new System.Drawing.Size(277, 56);
            this.StepGroupBox.TabIndex = 12;
            this.StepGroupBox.TabStop = false;
            this.StepGroupBox.Text = "Точность";
            // 
            // StepTextBox
            // 
            this.StepTextBox.Location = new System.Drawing.Point(15, 21);
            this.StepTextBox.Name = "StepTextBox";
            this.StepTextBox.Size = new System.Drawing.Size(225, 22);
            this.StepTextBox.TabIndex = 0;
            this.StepTextBox.Text = "0,001";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.thirdEqButton);
            this.groupBox4.Controls.Add(this.secondEqButton);
            this.groupBox4.Controls.Add(this.firstEqButton);
            this.groupBox4.Location = new System.Drawing.Point(12, 249);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(277, 89);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Уравнение";
            // 
            // thirdEqButton
            // 
            this.thirdEqButton.AutoSize = true;
            this.thirdEqButton.Location = new System.Drawing.Point(8, 65);
            this.thirdEqButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thirdEqButton.Name = "thirdEqButton";
            this.thirdEqButton.Size = new System.Drawing.Size(111, 20);
            this.thirdEqButton.TabIndex = 2;
            this.thirdEqButton.Text = "x^2 + 2x - 3 = 0";
            this.thirdEqButton.UseVisualStyleBackColor = true;
            // 
            // secondEqButton
            // 
            this.secondEqButton.AutoSize = true;
            this.secondEqButton.Checked = true;
            this.secondEqButton.Location = new System.Drawing.Point(8, 43);
            this.secondEqButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondEqButton.Name = "secondEqButton";
            this.secondEqButton.Size = new System.Drawing.Size(102, 20);
            this.secondEqButton.TabIndex = 1;
            this.secondEqButton.TabStop = true;
            this.secondEqButton.Text = "0.5x^2 - 1 = 0";
            this.secondEqButton.UseVisualStyleBackColor = true;
            // 
            // firstEqButton
            // 
            this.firstEqButton.AutoSize = true;
            this.firstEqButton.Location = new System.Drawing.Point(8, 19);
            this.firstEqButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstEqButton.Name = "firstEqButton";
            this.firstEqButton.Size = new System.Drawing.Size(84, 20);
            this.firstEqButton.TabIndex = 0;
            this.firstEqButton.Text = "ln x - 8 = 0";
            this.firstEqButton.UseVisualStyleBackColor = true;
            // 
            // interpolateCheckBox
            // 
            this.interpolateCheckBox.AutoSize = true;
            this.interpolateCheckBox.Location = new System.Drawing.Point(9, 406);
            this.interpolateCheckBox.Name = "interpolateCheckBox";
            this.interpolateCheckBox.Size = new System.Drawing.Size(116, 20);
            this.interpolateCheckBox.TabIndex = 13;
            this.interpolateCheckBox.Text = "Округлять до";
            this.interpolateCheckBox.UseVisualStyleBackColor = true;
            // 
            // numericUDChars
            // 
            this.numericUDChars.Location = new System.Drawing.Point(7, 432);
            this.numericUDChars.Name = "numericUDChars";
            this.numericUDChars.Size = new System.Drawing.Size(62, 22);
            this.numericUDChars.TabIndex = 14;
            this.numericUDChars.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "знаков";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(305, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ответ: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.Controls.Add(this.ResultLabel);
            this.panel2.Location = new System.Drawing.Point(390, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 53);
            this.panel2.TabIndex = 17;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(16, 10);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(69, 29);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "X = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(837, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUDChars);
            this.Controls.Add(this.interpolateCheckBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.StepGroupBox);
            this.Controls.Add(this.BordersGroupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.MethodGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Лаб №5 РПВС";
            this.MethodGroupBox.ResumeLayout(false);
            this.MethodGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BordersGroupBox.ResumeLayout(false);
            this.BordersGroupBox.PerformLayout();
            this.StepGroupBox.ResumeLayout(false);
            this.StepGroupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDChars)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox MethodGroupBox;
        private RadioButton NewtonButton;
        private RadioButton ItterationButton;
        private RadioButton HalfDivisionButton;
        private Button SolveButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Panel panel1;
        private Label label5;
        private GroupBox BordersGroupBox;
        private Label label1;
        private TextBox UBorderTextBox;
        private TextBox LBorderTextBox;
        private GroupBox StepGroupBox;
        private TextBox StepTextBox;
        private GroupBox groupBox4;
        private RadioButton thirdEqButton;
        private RadioButton secondEqButton;
        private RadioButton firstEqButton;
        private CheckBox interpolateCheckBox;
        private NumericUpDown numericUDChars;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label ResultLabel;
    }
}
