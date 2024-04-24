using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab8._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double[] probs = { 0, 0.2, 0.1, 0.1, 0.6 };
        private Random rand = new Random();
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double[] arr = { double.Parse(prob1input.Text), double.Parse(prob2input.Text), double.Parse(prob3input.Text), double.Parse(prob4input.Text), 0 };
                arr[4] = 1 - arr.Sum();
                if (arr[4] < 0) throw new Exception("Сумма чисел не должна превышать единицы");
                probs = arr;
            }
            catch (Exception ex)
            {
                errLabel.Visible = true;
                errLabel.Text = ex.Message;
                return;
            }

            prob5input.Text = probs[4].ToString();
            button1.Enabled = true;
            errLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] statistic = new int[probs.Length];

            double P;
            int N = (int)numericUpDown1.Value;

            for (int i = 0; i < N; i++)
            {
                P = rand.NextDouble();
                for (int j = 0; j < probs.Length; j++)
                {
                    P -= probs[j];
                    if (P <= 0)
                    {
                        statistic[j]++;
                        break;
                    }
                }
            }

            chart.Series[0].Points.Clear();
            for (int j = 0; j < probs.Length; j++)
            {
                chart.Series[0].Points.AddXY(j + 1, (double)statistic[j] / (double)N);
            }
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}