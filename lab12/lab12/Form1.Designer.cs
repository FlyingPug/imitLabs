namespace lab12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox = new PictureBox();
            DataResult = new DataGridView();
            Distribution = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataResult).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox
            // 
            pictureBox.ErrorImage = (Image)resources.GetObject("pictureBox.ErrorImage");
            pictureBox.InitialImage = (Image)resources.GetObject("pictureBox.InitialImage");
            pictureBox.Location = new Point(192, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(559, 579);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // DataResult
            // 
            DataResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataResult.Columns.AddRange(new DataGridViewColumn[] { Distribution });
            DataResult.Location = new Point(21, 3);
            DataResult.Name = "DataResult";
            DataResult.RowTemplate.Height = 25;
            DataResult.Size = new Size(149, 579);
            DataResult.TabIndex = 1;
            // 
            // Distribution
            // 
            Distribution.HeaderText = "Column1";
            Distribution.Name = "Distribution";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 594);
            Controls.Add(DataResult);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox;
        private DataGridView DataResult;
        private DataGridViewTextBoxColumn Distribution;
    }
}
