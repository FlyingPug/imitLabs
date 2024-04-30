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
            ChartArea chartArea1 = new ChartArea();
            Series series1 = new Series();
            panel1 = new Panel();
            errLabel = new Label();
            prob5input = new TextBox();
            prob4input = new TextBox();
            prob3input = new TextBox();
            prob2input = new TextBox();
            prob1input = new TextBox();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chart = new Chart();
            DataResult = new DataGridView();
            RF = new DataGridViewTextBoxColumn();
            RE = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label8 = new Label();
            Mean = new Label();
            Dispersion = new Label();
            label10 = new Label();
            label11 = new Label();
            ChiSquare = new Label();
            label12 = new Label();
            label13 = new Label();
            REM = new Label();
            REV = new Label();
            HypRes = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataResult).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(errLabel);
            panel1.Controls.Add(prob5input);
            panel1.Controls.Add(prob4input);
            panel1.Controls.Add(prob3input);
            panel1.Controls.Add(prob2input);
            panel1.Controls.Add(prob1input);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(35, 28);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 206);
            panel1.TabIndex = 0;
            // 
            // errLabel
            // 
            errLabel.AutoSize = true;
            errLabel.ForeColor = Color.Red;
            errLabel.Location = new Point(10, 160);
            errLabel.Name = "errLabel";
            errLabel.Size = new Size(18, 15);
            errLabel.TabIndex = 13;
            errLabel.Text = "es";
            errLabel.Visible = false;
            // 
            // prob5input
            // 
            prob5input.Enabled = false;
            prob5input.Location = new Point(57, 115);
            prob5input.Margin = new Padding(3, 2, 3, 2);
            prob5input.Name = "prob5input";
            prob5input.Size = new Size(56, 23);
            prob5input.TabIndex = 12;
            prob5input.Text = "0,6";
            prob5input.TextChanged += textBox_TextChanged;
            // 
            // prob4input
            // 
            prob4input.Location = new Point(57, 89);
            prob4input.Margin = new Padding(3, 2, 3, 2);
            prob4input.Name = "prob4input";
            prob4input.Size = new Size(56, 23);
            prob4input.TabIndex = 11;
            prob4input.Text = "0,1";
            prob4input.TextChanged += textBox_TextChanged;
            // 
            // prob3input
            // 
            prob3input.Location = new Point(57, 64);
            prob3input.Margin = new Padding(3, 2, 3, 2);
            prob3input.Name = "prob3input";
            prob3input.Size = new Size(56, 23);
            prob3input.TabIndex = 10;
            prob3input.Text = "0,1";
            prob3input.TextChanged += textBox_TextChanged;
            // 
            // prob2input
            // 
            prob2input.Location = new Point(57, 38);
            prob2input.Margin = new Padding(3, 2, 3, 2);
            prob2input.Name = "prob2input";
            prob2input.Size = new Size(56, 23);
            prob2input.TabIndex = 9;
            prob2input.Text = "0,2";
            prob2input.TextChanged += textBox_TextChanged;
            // 
            // prob1input
            // 
            prob1input.Location = new Point(57, 14);
            prob1input.Margin = new Padding(3, 2, 3, 2);
            prob1input.Name = "prob1input";
            prob1input.Size = new Size(56, 23);
            prob1input.TabIndex = 8;
            prob1input.Text = "0";
            prob1input.TextChanged += textBox_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(118, 137);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(83, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(57, 182);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 6;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 137);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 5;
            label6.Text = "Number of trials";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 115);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "Prob5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 92);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Prob4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 64);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Prob3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 38);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Prob2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Prob1";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            chart.Location = new Point(295, 28);
            chart.Margin = new Padding(3, 2, 3, 2);
            chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(380, 290);
            chart.TabIndex = 14;
            chart.Click += chart_Click_1;
            // 
            // DataResult
            // 
            DataResult.AllowUserToAddRows = false;
            DataResult.AllowUserToDeleteRows = false;
            DataResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataResult.Columns.AddRange(new DataGridViewColumn[] { RF, RE });
            DataResult.Location = new Point(35, 250);
            DataResult.Name = "DataResult";
            DataResult.ReadOnly = true;
            DataResult.RowTemplate.Height = 25;
            DataResult.Size = new Size(204, 277);
            DataResult.TabIndex = 15;
            DataResult.CellContentClick += DataResult_CellContentClick;
            // 
            // RF
            // 
            RF.HeaderText = "RF";
            RF.Name = "RF";
            RF.ReadOnly = true;
            // 
            // RE
            // 
            RE.HeaderText = "RE";
            RE.Name = "RE";
            RE.ReadOnly = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(295, 353);
            label7.Name = "label7";
            label7.Size = new Size(124, 15);
            label7.TabIndex = 14;
            label7.Text = "Выборочная средняя";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(295, 385);
            label8.Name = "label8";
            label8.Size = new Size(138, 15);
            label8.TabIndex = 16;
            label8.Text = "Выборочная дисперсия";
            // 
            // Mean
            // 
            Mean.AutoSize = true;
            Mean.Location = new Point(425, 353);
            Mean.Name = "Mean";
            Mean.Size = new Size(13, 15);
            Mean.TabIndex = 17;
            Mean.Text = "0";
            // 
            // Dispersion
            // 
            Dispersion.AutoSize = true;
            Dispersion.Location = new Point(425, 385);
            Dispersion.Name = "Dispersion";
            Dispersion.Size = new Size(13, 15);
            Dispersion.TabIndex = 18;
            Dispersion.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(295, 512);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 20;
            label10.Text = "Вывод";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(295, 483);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 21;
            label11.Text = "Кси квадрат";
            // 
            // ChiSquare
            // 
            ChiSquare.AutoSize = true;
            ChiSquare.Location = new Point(373, 483);
            ChiSquare.Name = "ChiSquare";
            ChiSquare.Size = new Size(72, 15);
            ChiSquare.TabIndex = 22;
            ChiSquare.Text = "Кси квадрат";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(295, 415);
            label12.Name = "label12";
            label12.Size = new Size(215, 15);
            label12.TabIndex = 23;
            label12.Text = "Относительная погрешность средняя";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(295, 444);
            label13.Name = "label13";
            label13.Size = new Size(229, 15);
            label13.TabIndex = 24;
            label13.Text = "Относительная погрешность дисперсия";
            // 
            // REM
            // 
            REM.AutoSize = true;
            REM.Location = new Point(516, 415);
            REM.Name = "REM";
            REM.Size = new Size(13, 15);
            REM.TabIndex = 25;
            REM.Text = "0";
            // 
            // REV
            // 
            REV.AutoSize = true;
            REV.Location = new Point(530, 444);
            REV.Name = "REV";
            REV.Size = new Size(13, 15);
            REV.TabIndex = 26;
            REV.Text = "0";
            // 
            // HypRes
            // 
            HypRes.AutoSize = true;
            HypRes.Location = new Point(343, 512);
            HypRes.Name = "HypRes";
            HypRes.Size = new Size(42, 15);
            HypRes.TabIndex = 27;
            HypRes.Text = "Вывод";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 550);
            Controls.Add(HypRes);
            Controls.Add(REV);
            Controls.Add(REM);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(ChiSquare);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(Dispersion);
            Controls.Add(Mean);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(DataResult);
            Controls.Add(panel1);
            Controls.Add(chart);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
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