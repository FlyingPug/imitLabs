namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Score.Text = $"{GetValue(20)} - {GetValue(5)}";
        }

        private int GetValue(double lambda)
        {
            double S = 0;
            int m = 0;
            Random random = new Random();

            while(S >= -lambda)
            {
                S += Math.Log(random.NextDouble());
                m++;
            }
            return m;
        }
    }
}