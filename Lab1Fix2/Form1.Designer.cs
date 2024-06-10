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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.IntegralLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MRMethodRadioButton = new System.Windows.Forms.RadioButton();
            this.RRMethodRadioButton = new System.Windows.Forms.RadioButton();
            this.LRMethodRadioButton = new System.Windows.Forms.RadioButton();
            this.TMethodRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBorderTextBox = new System.Windows.Forms.TextBox();
            this.UBorderTextBox = new System.Windows.Forms.TextBox();
            this.StepTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBorderLabel = new System.Windows.Forms.Label();
            this.UBorderLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IntegralLabel
            // 
            this.IntegralLabel.AutoSize = true;
            this.IntegralLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.IntegralLabel.Location = new System.Drawing.Point(28, 16);
            this.IntegralLabel.Name = "IntegralLabel";
            this.IntegralLabel.Size = new System.Drawing.Size(184, 46);
            this.IntegralLabel.TabIndex = 0;
            this.IntegralLabel.Text = "Интеграл:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MRMethodRadioButton);
            this.groupBox1.Controls.Add(this.RRMethodRadioButton);
            this.groupBox1.Controls.Add(this.LRMethodRadioButton);
            this.groupBox1.Controls.Add(this.TMethodRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(292, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод вычислений";
            // 
            // MRMethodRadioButton
            // 
            this.MRMethodRadioButton.AutoSize = true;
            this.MRMethodRadioButton.Location = new System.Drawing.Point(23, 106);
            this.MRMethodRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MRMethodRadioButton.Name = "MRMethodRadioButton";
            this.MRMethodRadioButton.Size = new System.Drawing.Size(245, 20);
            this.MRMethodRadioButton.TabIndex = 3;
            this.MRMethodRadioButton.TabStop = true;
            this.MRMethodRadioButton.Text = "Метод средних прямоугольников";
            this.MRMethodRadioButton.UseVisualStyleBackColor = true;
            this.MRMethodRadioButton.CheckedChanged += new System.EventHandler(this.MRMethodRadioButton_CheckedChanged);
            // 
            // RRMethodRadioButton
            // 
            this.RRMethodRadioButton.AutoSize = true;
            this.RRMethodRadioButton.Location = new System.Drawing.Point(23, 82);
            this.RRMethodRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RRMethodRadioButton.Name = "RRMethodRadioButton";
            this.RRMethodRadioButton.Size = new System.Drawing.Size(239, 20);
            this.RRMethodRadioButton.TabIndex = 2;
            this.RRMethodRadioButton.TabStop = true;
            this.RRMethodRadioButton.Text = "Метод правых прямоугольников";
            this.RRMethodRadioButton.UseVisualStyleBackColor = true;
            this.RRMethodRadioButton.CheckedChanged += new System.EventHandler(this.RRMethodRadioButton_CheckedChanged);
            // 
            // LRMethodRadioButton
            // 
            this.LRMethodRadioButton.AutoSize = true;
            this.LRMethodRadioButton.Location = new System.Drawing.Point(23, 58);
            this.LRMethodRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LRMethodRadioButton.Name = "LRMethodRadioButton";
            this.LRMethodRadioButton.Size = new System.Drawing.Size(231, 20);
            this.LRMethodRadioButton.TabIndex = 1;
            this.LRMethodRadioButton.TabStop = true;
            this.LRMethodRadioButton.Text = "Метод левых прямоугольников";
            this.LRMethodRadioButton.UseVisualStyleBackColor = true;
            this.LRMethodRadioButton.CheckedChanged += new System.EventHandler(this.LRMethodRadioButton_CheckedChanged);
            // 
            // TMethodRadioButton
            // 
            this.TMethodRadioButton.AutoSize = true;
            this.TMethodRadioButton.Checked = true;
            this.TMethodRadioButton.Location = new System.Drawing.Point(23, 34);
            this.TMethodRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TMethodRadioButton.Name = "TMethodRadioButton";
            this.TMethodRadioButton.Size = new System.Drawing.Size(136, 20);
            this.TMethodRadioButton.TabIndex = 0;
            this.TMethodRadioButton.TabStop = true;
            this.TMethodRadioButton.Text = "Метод трапеций";
            this.TMethodRadioButton.UseVisualStyleBackColor = true;
            this.TMethodRadioButton.CheckedChanged += new System.EventHandler(this.TMethodRadioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Нижняя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Верхняя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Шаги:";
            // 
            // LBorderTextBox
            // 
            this.LBorderTextBox.Location = new System.Drawing.Point(15, 281);
            this.LBorderTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBorderTextBox.Name = "LBorderTextBox";
            this.LBorderTextBox.Size = new System.Drawing.Size(68, 22);
            this.LBorderTextBox.TabIndex = 5;
            this.LBorderTextBox.Text = "0";
            // 
            // UBorderTextBox
            // 
            this.UBorderTextBox.Location = new System.Drawing.Point(125, 281);
            this.UBorderTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UBorderTextBox.Name = "UBorderTextBox";
            this.UBorderTextBox.Size = new System.Drawing.Size(68, 22);
            this.UBorderTextBox.TabIndex = 6;
            this.UBorderTextBox.Text = "1";
            // 
            // StepTextBox
            // 
            this.StepTextBox.Location = new System.Drawing.Point(236, 281);
            this.StepTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StepTextBox.Name = "StepTextBox";
            this.StepTextBox.Size = new System.Drawing.Size(68, 22);
            this.StepTextBox.TabIndex = 7;
            this.StepTextBox.Text = "0,01";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.ExitButton.Location = new System.Drawing.Point(74, 318);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(165, 49);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.PaleGoldenrod;
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.IsDockedInsideChartArea = false;
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(16, -33);
            this.chart.Name = "chart";
            series3.BorderWidth = 0;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Silver;
            series3.Legend = "Legend1";
            series3.LegendText = "Вычисляемая площадь";
            series3.Name = "Square";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Black;
            series4.Legend = "Legend1";
            series4.LegendText = "Функция";
            series4.Name = "Function";
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(484, 337);
            this.chart.TabIndex = 9;
            this.chart.Text = "chart1";
            title3.Name = "Вычисляемая площадь";
            title4.Name = "Функция";
            this.chart.Titles.Add(title3);
            this.chart.Titles.Add(title4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.chart);
            this.panel1.Location = new System.Drawing.Point(310, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 324);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.LBorderLabel);
            this.panel2.Controls.Add(this.UBorderLabel);
            this.panel2.Controls.Add(this.ResultLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(211, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 58);
            this.panel2.TabIndex = 11;
            // 
            // LBorderLabel
            // 
            this.LBorderLabel.AutoSize = true;
            this.LBorderLabel.Location = new System.Drawing.Point(66, 42);
            this.LBorderLabel.Name = "LBorderLabel";
            this.LBorderLabel.Size = new System.Drawing.Size(14, 16);
            this.LBorderLabel.TabIndex = 16;
            this.LBorderLabel.Text = "0";
            // 
            // UBorderLabel
            // 
            this.UBorderLabel.AutoSize = true;
            this.UBorderLabel.BackColor = System.Drawing.Color.Transparent;
            this.UBorderLabel.Location = new System.Drawing.Point(71, 2);
            this.UBorderLabel.Name = "UBorderLabel";
            this.UBorderLabel.Size = new System.Drawing.Size(14, 16);
            this.UBorderLabel.TabIndex = 15;
            this.UBorderLabel.Text = "1";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(231, 12);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 39);
            this.ResultLabel.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab1Fix.Properties.Resources.Equation2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(837, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StepTextBox);
            this.Controls.Add(this.UBorderTextBox);
            this.Controls.Add(this.LBorderTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.IntegralLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Лаб №1 РПВС";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label IntegralLabel;
        private GroupBox groupBox1;
        private RadioButton MRMethodRadioButton;
        private RadioButton RRMethodRadioButton;
        private RadioButton LRMethodRadioButton;
        private RadioButton TMethodRadioButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox LBorderTextBox;
        private TextBox UBorderTextBox;
        private TextBox StepTextBox;
        private Button ExitButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label ResultLabel;
        private Label LBorderLabel;
        private Label UBorderLabel;
    }
}
