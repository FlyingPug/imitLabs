using System.Windows.Forms.DataVisualization.Charting;

namespace Lab8._3
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errLabel = new System.Windows.Forms.Label();
            this.prob5input = new System.Windows.Forms.TextBox();
            this.prob4input = new System.Windows.Forms.TextBox();
            this.prob3input = new System.Windows.Forms.TextBox();
            this.prob2input = new System.Windows.Forms.TextBox();
            this.prob1input = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataResult = new System.Windows.Forms.DataGridView();
            this.RF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Mean = new System.Windows.Forms.Label();
            this.Dispersion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ChiSquare = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.REM = new System.Windows.Forms.Label();
            this.REV = new System.Windows.Forms.Label();
            this.HypRes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.errLabel);
            this.panel1.Controls.Add(this.prob5input);
            this.panel1.Controls.Add(this.prob4input);
            this.panel1.Controls.Add(this.prob3input);
            this.panel1.Controls.Add(this.prob2input);
            this.panel1.Controls.Add(this.prob1input);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(35, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 206);
            this.panel1.TabIndex = 0;
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.ForeColor = System.Drawing.Color.Red;
            this.errLabel.Location = new System.Drawing.Point(10, 160);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(18, 15);
            this.errLabel.TabIndex = 13;
            this.errLabel.Text = "es";
            this.errLabel.Visible = false;
            // 
            // prob5input
            // 
            this.prob5input.Enabled = false;
            this.prob5input.Location = new System.Drawing.Point(57, 115);
            this.prob5input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prob5input.Name = "prob5input";
            this.prob5input.Size = new System.Drawing.Size(56, 23);
            this.prob5input.TabIndex = 12;
            this.prob5input.Text = "0,6";
            this.prob5input.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // prob4input
            // 
            this.prob4input.Location = new System.Drawing.Point(57, 89);
            this.prob4input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prob4input.Name = "prob4input";
            this.prob4input.Size = new System.Drawing.Size(56, 23);
            this.prob4input.TabIndex = 11;
            this.prob4input.Text = "0,1";
            this.prob4input.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // prob3input
            // 
            this.prob3input.Location = new System.Drawing.Point(57, 64);
            this.prob3input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prob3input.Name = "prob3input";
            this.prob3input.Size = new System.Drawing.Size(56, 23);
            this.prob3input.TabIndex = 10;
            this.prob3input.Text = "0,1";
            this.prob3input.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // prob2input
            // 
            this.prob2input.Location = new System.Drawing.Point(57, 38);
            this.prob2input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prob2input.Name = "prob2input";
            this.prob2input.Size = new System.Drawing.Size(56, 23);
            this.prob2input.TabIndex = 9;
            this.prob2input.Text = "0,2";
            this.prob2input.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // prob1input
            // 
            this.prob1input.Location = new System.Drawing.Point(57, 14);
            this.prob1input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prob1input.Name = "prob1input";
            this.prob1input.Size = new System.Drawing.Size(56, 23);
            this.prob1input.TabIndex = 8;
            this.prob1input.Text = "0";
            this.prob1input.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(118, 137);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(83, 23);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(57, 182);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number of trials";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prob5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prob4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prob3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prob2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prob1";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(295, 28);
            this.chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(380, 290);
            this.chart.TabIndex = 14;
            this.chart.Click += new System.EventHandler(this.chart_Click_1);
            // 
            // DataResult
            // 
            this.DataResult.AllowUserToAddRows = false;
            this.DataResult.AllowUserToDeleteRows = false;
            this.DataResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RF,
            this.RE});
            this.DataResult.Location = new System.Drawing.Point(35, 250);
            this.DataResult.Name = "DataResult";
            this.DataResult.ReadOnly = true;
            this.DataResult.RowTemplate.Height = 25;
            this.DataResult.Size = new System.Drawing.Size(204, 277);
            this.DataResult.TabIndex = 15;
            // 
            // RF
            // 
            this.RF.HeaderText = "RF";
            this.RF.Name = "RF";
            this.RF.ReadOnly = true;
            // 
            // RE
            // 
            this.RE.HeaderText = "RE";
            this.RE.Name = "RE";
            this.RE.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Выборочная средняя";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Выборочная дисперсия";
            // 
            // Mean
            // 
            this.Mean.AutoSize = true;
            this.Mean.Location = new System.Drawing.Point(425, 353);
            this.Mean.Name = "Mean";
            this.Mean.Size = new System.Drawing.Size(13, 15);
            this.Mean.TabIndex = 17;
            this.Mean.Text = "0";
            // 
            // Dispersion
            // 
            this.Dispersion.AutoSize = true;
            this.Dispersion.Location = new System.Drawing.Point(425, 385);
            this.Dispersion.Name = "Dispersion";
            this.Dispersion.Size = new System.Drawing.Size(13, 15);
            this.Dispersion.TabIndex = 18;
            this.Dispersion.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 512);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Вывод";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 483);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Кси квадрат";
            // 
            // ChiSquare
            // 
            this.ChiSquare.AutoSize = true;
            this.ChiSquare.Location = new System.Drawing.Point(373, 483);
            this.ChiSquare.Name = "ChiSquare";
            this.ChiSquare.Size = new System.Drawing.Size(72, 15);
            this.ChiSquare.TabIndex = 22;
            this.ChiSquare.Text = "Кси квадрат";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 415);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Относительная погрешность средняя";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(295, 444);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(229, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Относительная погрешность дисперсия";
            // 
            // REM
            // 
            this.REM.AutoSize = true;
            this.REM.Location = new System.Drawing.Point(516, 415);
            this.REM.Name = "REM";
            this.REM.Size = new System.Drawing.Size(13, 15);
            this.REM.TabIndex = 25;
            this.REM.Text = "0";
            // 
            // REV
            // 
            this.REV.AutoSize = true;
            this.REV.Location = new System.Drawing.Point(530, 444);
            this.REV.Name = "REV";
            this.REV.Size = new System.Drawing.Size(13, 15);
            this.REV.TabIndex = 26;
            this.REV.Text = "0";
            // 
            // HypRes
            // 
            this.HypRes.AutoSize = true;
            this.HypRes.Location = new System.Drawing.Point(343, 512);
            this.HypRes.Name = "HypRes";
            this.HypRes.Size = new System.Drawing.Size(42, 15);
            this.HypRes.TabIndex = 27;
            this.HypRes.Text = "Вывод";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.HypRes);
            this.Controls.Add(this.REV);
            this.Controls.Add(this.REM);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ChiSquare);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Dispersion);
            this.Controls.Add(this.Mean);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DataResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox prob5input;
        private TextBox prob4input;
        private TextBox prob3input;
        private TextBox prob2input;
        private TextBox prob1input;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label6;
        private Label errLabel;
        private Chart chart;
        private DataGridView DataResult;
        private DataGridViewTextBoxColumn RF;
        private DataGridViewTextBoxColumn RE;
        private Label label7;
        private Label label8;
        private Label Mean;
        private Label Dispersion;
        private Label label10;
        private Label label11;
        private Label ChiSquare;
        private Label label12;
        private Label label13;
        private Label REM;
        private Label REV;
        private Label HypRes;
    }
}