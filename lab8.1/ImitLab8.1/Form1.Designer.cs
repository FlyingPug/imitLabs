namespace ImitLab8._1
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
            label1 = new Label();
            label2 = new Label();
            Answer = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(278, 91);
            label1.Name = "label1";
            label1.Size = new Size(261, 32);
            label1.TabIndex = 0;
            label1.Text = "Сегодня будет дождь?";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumTurquoise;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(359, 148);
            label2.Name = "label2";
            label2.Size = new Size(97, 41);
            label2.TabIndex = 1;
            label2.Text = "Ответ";
            // 
            // Answer
            // 
            Answer.AutoSize = true;
            Answer.BackColor = Color.Violet;
            Answer.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Answer.ForeColor = Color.White;
            Answer.Location = new Point(359, 205);
            Answer.Name = "Answer";
            Answer.Size = new Size(97, 41);
            Answer.TabIndex = 2;
            Answer.Text = "Ответ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Answer);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Answer;
    }
}