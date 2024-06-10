namespace Lab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.methodGBox = new System.Windows.Forms.GroupBox();
            this.rungeKutta4RButton = new System.Windows.Forms.RadioButton();
            this.trapezoidalRButton = new System.Windows.Forms.RadioButton();
            this.eulerRButton = new System.Windows.Forms.RadioButton();
            this.rungeKutta3RButton = new System.Windows.Forms.RadioButton();
            this.equationGBox = new System.Windows.Forms.GroupBox();
            this.thirdEqRButton = new System.Windows.Forms.RadioButton();
            this.secondEqRButton = new System.Windows.Forms.RadioButton();
            this.firstEqRButton = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LBtextBox = new System.Windows.Forms.TextBox();
            this.UBtextBox = new System.Windows.Forms.TextBox();
            this.SteptextBox = new System.Windows.Forms.TextBox();
            this.SolveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.y0textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StringListRButton = new System.Windows.Forms.RadioButton();
            this.DynamicArrRButton = new System.Windows.Forms.RadioButton();
            this.methodGBox.SuspendLayout();
            this.equationGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // methodGBox
            // 
            this.methodGBox.Controls.Add(this.rungeKutta4RButton);
            this.methodGBox.Controls.Add(this.trapezoidalRButton);
            this.methodGBox.Controls.Add(this.eulerRButton);
            this.methodGBox.Controls.Add(this.rungeKutta3RButton);
            this.methodGBox.Location = new System.Drawing.Point(13, 13);
            this.methodGBox.Name = "methodGBox";
            this.methodGBox.Size = new System.Drawing.Size(215, 124);
            this.methodGBox.TabIndex = 0;
            this.methodGBox.TabStop = false;
            this.methodGBox.Text = "Метод решения";
            // 
            // rungeKutta4RButton
            // 
            this.rungeKutta4RButton.AutoSize = true;
            this.rungeKutta4RButton.Location = new System.Drawing.Point(7, 98);
            this.rungeKutta4RButton.Name = "rungeKutta4RButton";
            this.rungeKutta4RButton.Size = new System.Drawing.Size(194, 20);
            this.rungeKutta4RButton.TabIndex = 3;
            this.rungeKutta4RButton.Text = "Рунге-Кутта 4-го порядка";
            this.rungeKutta4RButton.UseVisualStyleBackColor = true;
            this.rungeKutta4RButton.CheckedChanged += new System.EventHandler(this.rungeKutta4RButton_CheckedChanged);
            // 
            // trapezoidalRButton
            // 
            this.trapezoidalRButton.AutoSize = true;
            this.trapezoidalRButton.Location = new System.Drawing.Point(7, 48);
            this.trapezoidalRButton.Name = "trapezoidalRButton";
            this.trapezoidalRButton.Size = new System.Drawing.Size(93, 20);
            this.trapezoidalRButton.TabIndex = 1;
            this.trapezoidalRButton.Text = "Трапеций";
            this.trapezoidalRButton.UseVisualStyleBackColor = true;
            this.trapezoidalRButton.CheckedChanged += new System.EventHandler(this.trapezoidalRButton_CheckedChanged);
            // 
            // eulerRButton
            // 
            this.eulerRButton.AutoSize = true;
            this.eulerRButton.Checked = true;
            this.eulerRButton.Location = new System.Drawing.Point(7, 22);
            this.eulerRButton.Name = "eulerRButton";
            this.eulerRButton.Size = new System.Drawing.Size(78, 20);
            this.eulerRButton.TabIndex = 0;
            this.eulerRButton.TabStop = true;
            this.eulerRButton.Text = "Эйлера";
            this.eulerRButton.UseVisualStyleBackColor = true;
            this.eulerRButton.CheckedChanged += new System.EventHandler(this.eulerRButton_CheckedChanged);
            // 
            // rungeKutta3RButton
            // 
            this.rungeKutta3RButton.AutoSize = true;
            this.rungeKutta3RButton.Location = new System.Drawing.Point(7, 74);
            this.rungeKutta3RButton.Name = "rungeKutta3RButton";
            this.rungeKutta3RButton.Size = new System.Drawing.Size(194, 20);
            this.rungeKutta3RButton.TabIndex = 2;
            this.rungeKutta3RButton.Text = "Рунге-Кутта 3-го порядка";
            this.rungeKutta3RButton.UseVisualStyleBackColor = true;
            this.rungeKutta3RButton.CheckedChanged += new System.EventHandler(this.rungeKutta3RButton_CheckedChanged);
            // 
            // equationGBox
            // 
            this.equationGBox.Controls.Add(this.thirdEqRButton);
            this.equationGBox.Controls.Add(this.secondEqRButton);
            this.equationGBox.Controls.Add(this.firstEqRButton);
            this.equationGBox.Location = new System.Drawing.Point(13, 143);
            this.equationGBox.Name = "equationGBox";
            this.equationGBox.Size = new System.Drawing.Size(216, 100);
            this.equationGBox.TabIndex = 1;
            this.equationGBox.TabStop = false;
            this.equationGBox.Text = "Уравнение";
            // 
            // thirdEqRButton
            // 
            this.thirdEqRButton.AutoSize = true;
            this.thirdEqRButton.Checked = true;
            this.thirdEqRButton.Location = new System.Drawing.Point(7, 73);
            this.thirdEqRButton.Name = "thirdEqRButton";
            this.thirdEqRButton.Size = new System.Drawing.Size(100, 20);
            this.thirdEqRButton.TabIndex = 4;
            this.thirdEqRButton.TabStop = true;
            this.thirdEqRButton.Text = "y\' = sin(x) * y";
            this.thirdEqRButton.UseVisualStyleBackColor = true;
            this.thirdEqRButton.CheckedChanged += new System.EventHandler(this.thirdEqRButton_CheckedChanged);
            // 
            // secondEqRButton
            // 
            this.secondEqRButton.AutoSize = true;
            this.secondEqRButton.Location = new System.Drawing.Point(7, 47);
            this.secondEqRButton.Name = "secondEqRButton";
            this.secondEqRButton.Size = new System.Drawing.Size(125, 20);
            this.secondEqRButton.TabIndex = 3;
            this.secondEqRButton.Text = "y\' = (1 - 2*x)/(y*y)";
            this.secondEqRButton.UseVisualStyleBackColor = true;
            this.secondEqRButton.CheckedChanged += new System.EventHandler(this.secondEqRButton_CheckedChanged);
            // 
            // firstEqRButton
            // 
            this.firstEqRButton.AutoSize = true;
            this.firstEqRButton.Location = new System.Drawing.Point(7, 21);
            this.firstEqRButton.Name = "firstEqRButton";
            this.firstEqRButton.Size = new System.Drawing.Size(118, 20);
            this.firstEqRButton.TabIndex = 2;
            this.firstEqRButton.Text = "y\' = 3*x - 2*y + 5";
            this.firstEqRButton.UseVisualStyleBackColor = true;
            this.firstEqRButton.CheckedChanged += new System.EventHandler(this.firstEqRButton_CheckedChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(234, 13);
            this.chart1.Name = "chart1";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.MarkerColor = System.Drawing.Color.Blue;
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series8.Name = "Graphic";
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(770, 497);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // LBtextBox
            // 
            this.LBtextBox.Location = new System.Drawing.Point(17, 394);
            this.LBtextBox.Name = "LBtextBox";
            this.LBtextBox.Size = new System.Drawing.Size(93, 22);
            this.LBtextBox.TabIndex = 3;
            this.LBtextBox.Text = "1";
            // 
            // UBtextBox
            // 
            this.UBtextBox.Location = new System.Drawing.Point(116, 394);
            this.UBtextBox.Name = "UBtextBox";
            this.UBtextBox.Size = new System.Drawing.Size(101, 22);
            this.UBtextBox.TabIndex = 4;
            this.UBtextBox.Text = "2";
            // 
            // SteptextBox
            // 
            this.SteptextBox.Location = new System.Drawing.Point(51, 422);
            this.SteptextBox.Name = "SteptextBox";
            this.SteptextBox.Size = new System.Drawing.Size(93, 22);
            this.SteptextBox.TabIndex = 5;
            this.SteptextBox.Text = "0,1";
            // 
            // SolveButton
            // 
            this.SolveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SolveButton.Location = new System.Drawing.Point(14, 476);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(201, 39);
            this.SolveButton.TabIndex = 6;
            this.SolveButton.Text = "Рассчитать";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1010, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Таблица:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridView.Location = new System.Drawing.Point(865, 61);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(321, 449);
            this.dataGridView.TabIndex = 8;
            // 
            // X
            // 
            this.X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 44;
            // 
            // Y
            // 
            this.Y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Промежуток:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(2, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "[                ,                 ]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Шаг:";
            // 
            // y0textBox
            // 
            this.y0textBox.Location = new System.Drawing.Point(53, 450);
            this.y0textBox.Name = "y0textBox";
            this.y0textBox.Size = new System.Drawing.Size(93, 22);
            this.y0textBox.TabIndex = 13;
            this.y0textBox.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "y0 = ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StringListRButton);
            this.groupBox1.Controls.Add(this.DynamicArrRButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 82);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод хранения";
            // 
            // StringListRButton
            // 
            this.StringListRButton.AutoSize = true;
            this.StringListRButton.Location = new System.Drawing.Point(7, 48);
            this.StringListRButton.Name = "StringListRButton";
            this.StringListRButton.Size = new System.Drawing.Size(115, 20);
            this.StringListRButton.TabIndex = 1;
            this.StringListRButton.Text = "Список строк";
            this.StringListRButton.UseVisualStyleBackColor = true;
            this.StringListRButton.CheckedChanged += new System.EventHandler(this.StringListRButton_CheckedChanged);
            // 
            // DynamicArrRButton
            // 
            this.DynamicArrRButton.AutoSize = true;
            this.DynamicArrRButton.Checked = true;
            this.DynamicArrRButton.Location = new System.Drawing.Point(7, 22);
            this.DynamicArrRButton.Name = "DynamicArrRButton";
            this.DynamicArrRButton.Size = new System.Drawing.Size(174, 20);
            this.DynamicArrRButton.TabIndex = 0;
            this.DynamicArrRButton.TabStop = true;
            this.DynamicArrRButton.Text = "Динамический массив";
            this.DynamicArrRButton.UseVisualStyleBackColor = true;
            this.DynamicArrRButton.CheckedChanged += new System.EventHandler(this.DynamicArrRButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.y0textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.SteptextBox);
            this.Controls.Add(this.UBtextBox);
            this.Controls.Add(this.LBtextBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.equationGBox);
            this.Controls.Add(this.methodGBox);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.methodGBox.ResumeLayout(false);
            this.methodGBox.PerformLayout();
            this.equationGBox.ResumeLayout(false);
            this.equationGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox methodGBox;
        private System.Windows.Forms.RadioButton rungeKutta3RButton;
        private System.Windows.Forms.RadioButton trapezoidalRButton;
        private System.Windows.Forms.RadioButton eulerRButton;
        private System.Windows.Forms.GroupBox equationGBox;
        private System.Windows.Forms.RadioButton thirdEqRButton;
        private System.Windows.Forms.RadioButton secondEqRButton;
        private System.Windows.Forms.RadioButton firstEqRButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox LBtextBox;
        private System.Windows.Forms.TextBox UBtextBox;
        private System.Windows.Forms.TextBox SteptextBox;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox y0textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rungeKutta4RButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton StringListRButton;
        private System.Windows.Forms.RadioButton DynamicArrRButton;
    }
}

