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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
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
            panel1.Location = new Point(40, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 275);
            panel1.TabIndex = 0;
            // 
            // errLabel
            // 
            errLabel.AutoSize = true;
            errLabel.ForeColor = Color.Red;
            errLabel.Location = new Point(12, 213);
            errLabel.Name = "errLabel";
            errLabel.Size = new Size(23, 20);
            errLabel.TabIndex = 13;
            errLabel.Text = "es";
            errLabel.Visible = false;
            // 
            // prob5input
            // 
            prob5input.Enabled = false;
            prob5input.Location = new Point(65, 153);
            prob5input.Name = "prob5input";
            prob5input.Size = new Size(64, 27);
            prob5input.TabIndex = 12;
            prob5input.Text = "0,6";
            // 
            // prob4input
            // 
            prob4input.Location = new Point(65, 119);
            prob4input.Name = "prob4input";
            prob4input.Size = new Size(64, 27);
            prob4input.TabIndex = 11;
            prob4input.Text = "0,1";
            prob4input.TextChanged += textBox_TextChanged;
            // 
            // prob3input
            // 
            prob3input.Location = new Point(65, 86);
            prob3input.Name = "prob3input";
            prob3input.Size = new Size(64, 27);
            prob3input.TabIndex = 10;
            prob3input.Text = "0,1";
            prob3input.TextChanged += textBox_TextChanged;
            // 
            // prob2input
            // 
            prob2input.Location = new Point(65, 51);
            prob2input.Name = "prob2input";
            prob2input.Size = new Size(64, 27);
            prob2input.TabIndex = 9;
            prob2input.Text = "0,2";
            prob2input.TextChanged += textBox_TextChanged;
            // 
            // prob1input
            // 
            prob1input.Location = new Point(65, 18);
            prob1input.Name = "prob1input";
            prob1input.Size = new Size(64, 27);
            prob1input.TabIndex = 8;
            prob1input.Text = "0";
            prob1input.TextChanged += textBox_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(135, 183);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(95, 27);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(65, 243);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 183);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 5;
            label6.Text = "Number of trials";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 153);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 4;
            label5.Text = "Prob5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 122);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 3;
            label4.Text = "Prob4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Prob3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Prob2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Prob1";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            chart.Location = new Point(337, 38);
            chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(434, 387);
            chart.TabIndex = 14;
            chart.Click += chart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(chart);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
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
    }
}