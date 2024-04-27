namespace lab10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Score = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(294, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 220);
            this.panel1.TabIndex = 0;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Score.Location = new System.Drawing.Point(285, 259);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(245, 125);
            this.Score.TabIndex = 1;
            this.Score.Text = "0 - 0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Location = new System.Drawing.Point(12, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 395);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(714, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(74, 384);
            this.panel3.TabIndex = 3;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.DarkGreen;
            this.PlayButton.ForeColor = System.Drawing.Color.Snow;
            this.PlayButton.Location = new System.Drawing.Point(294, 402);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(220, 36);
            this.PlayButton.TabIndex = 4;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label Score;
        private Panel panel2;
        private Panel panel3;
        private Button PlayButton;
    }
}