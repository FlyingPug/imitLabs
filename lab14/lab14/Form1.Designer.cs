namespace lab14
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
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            ClinetsInLine = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(86, 100);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(183, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(86, 100);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(355, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(86, 100);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Location = new Point(539, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(86, 100);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Location = new Point(702, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(86, 100);
            panel5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 124);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 5;
            label1.Text = "Clients in line:";
            // 
            // ClinetsInLine
            // 
            ClinetsInLine.AutoSize = true;
            ClinetsInLine.Location = new Point(100, 124);
            ClinetsInLine.Name = "ClinetsInLine";
            ClinetsInLine.Size = new Size(38, 15);
            ClinetsInLine.TabIndex = 6;
            ClinetsInLine.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClinetsInLine);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Label ClinetsInLine;
    }
}
