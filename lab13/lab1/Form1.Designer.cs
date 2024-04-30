using System.Windows.Forms.DataVisualization.Charting;

namespace lab1
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
            components = new System.ComponentModel.Container();
            ChartArea chartArea1 = new ChartArea();
            Series series1 = new Series();
            Series series2 = new Series();
            panel1 = new Panel();
            StopButton = new Button();
            inputPrice2 = new NumericUpDown();
            InitialPriceLabel = new Label();
            inputPrice1 = new NumericUpDown();
            StartButton = new Button();
            MyChart = new Chart();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputPrice2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputPrice1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyChart).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(StopButton);
            panel1.Controls.Add(inputPrice2);
            panel1.Controls.Add(InitialPriceLabel);
            panel1.Controls.Add(inputPrice1);
            panel1.Controls.Add(StartButton);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 44);
            panel1.TabIndex = 0;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(346, 7);
            StopButton.Margin = new Padding(3, 2, 3, 2);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(94, 22);
            StopButton.TabIndex = 9;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // inputPrice2
            // 
            inputPrice2.Location = new Point(180, 8);
            inputPrice2.Margin = new Padding(3, 2, 3, 2);
            inputPrice2.Name = "inputPrice2";
            inputPrice2.Size = new Size(72, 23);
            inputPrice2.TabIndex = 7;
            inputPrice2.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // InitialPriceLabel
            // 
            InitialPriceLabel.AutoSize = true;
            InitialPriceLabel.Location = new Point(9, 10);
            InitialPriceLabel.Name = "InitialPriceLabel";
            InitialPriceLabel.Size = new Size(65, 15);
            InitialPriceLabel.TabIndex = 2;
            InitialPriceLabel.Text = "Initial price";
            InitialPriceLabel.Click += label1_Click;
            // 
            // inputPrice1
            // 
            inputPrice1.Location = new Point(87, 8);
            inputPrice1.Margin = new Padding(3, 2, 3, 2);
            inputPrice1.Name = "inputPrice1";
            inputPrice1.Size = new Size(77, 23);
            inputPrice1.TabIndex = 1;
            inputPrice1.Value = new decimal(new int[] { 90, 0, 0, 0 });
            inputPrice1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(257, 7);
            StartButton.Margin = new Padding(3, 2, 3, 2);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(83, 22);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += button1_Click;
            // 
            // MyChart
            // 
            MyChart.BackImageAlignment = ChartImageAlignmentStyle.Top;
            MyChart.BorderlineColor = SystemColors.WindowFrame;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 50D;
            chartArea1.Name = "ChartArea1";
            MyChart.ChartAreas.Add(chartArea1);
            MyChart.Location = new Point(10, 51);
            MyChart.Margin = new Padding(3, 2, 3, 2);
            MyChart.Name = "MyChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Line;
            series1.Color = Color.Green;
            series1.Name = "Series2";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Line;
            series2.Color = Color.BlueViolet;
            series2.Name = "Series3";
            series2.XValueType = ChartValueType.Int32;
            MyChart.Series.Add(series1);
            MyChart.Series.Add(series2);
            MyChart.Size = new Size(612, 525);
            MyChart.TabIndex = 1;
            MyChart.Click += MyChart_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 572);
            Controls.Add(MyChart);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputPrice2).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputPrice1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label InitialPriceLabel;
        private NumericUpDown inputPrice1;
        private Button StartButton;
        private NumericUpDown inputPrice2;
        private Chart MyChart;
        private System.Windows.Forms.Timer timer1;
        private Button StopButton;
    }
}