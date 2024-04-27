using System;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;
using MathNet.Numerics.Distributions;

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
        private const double alpha = 0.05;
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
            double[] freqs = new double[probs.Length];

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
                freqs[j] = (double)statistic[j] / (double)N;
                chart.Series[0].Points.AddXY(j + 1, freqs[j]);
                if (DataResult.Rows.Count <= j) DataResult.Rows.Add(0, 0);
                DataResult.Rows[j].Cells[0].Value = freqs[j];
            }
            double mean = getMean(freqs);
            double var = getVar(freqs, mean);
            Mean.Text = mean.ToString(); 
            Dispersion.Text = var.ToString();
            double generalMean = getMean(probs);
            double generalVar = getVar(probs, generalMean);

            double relErrorMean = Math.Abs(generalMean - mean) / Math.Abs(generalMean);
            double relErrorVar = Math.Abs(generalVar - var) / Math.Abs(generalVar);
            double chiSquare = getChiSquare(statistic, probs, N);
            ChiSquare.Text = chiSquare.ToString();
            REM.Text = relErrorMean.ToString();
            REV.Text = relErrorVar.ToString();

            int df = probs.Length - 1;
            double tableValue = ChiSquared.InvCDF(df, 1 - alpha);
            bool isAccepted = chiSquare <= tableValue ;
            HypRes.Text = isAccepted ? "Принимается" : "Отклоняется";
        }

        private double getChiSquare(int[] observed, double[] expected, int N)
        {
            double chiSquare = 0;

            for (int i = 0; i < observed.Length; i++)
            {
                if (expected[i] > 0)
                chiSquare += (observed[i] - (expected[i] * N)) * (observed[i] - (expected[i] * N)) / (expected[i] * N);
            }

            return chiSquare;
        }

        private double getVar(IList<double> freqs, double mean)
        {
            double variance = 0;
            for(int i = 0; i < freqs.Count(); i++)
            {
                variance += freqs[i] * i * i;
            }
            return variance - Math.Pow(mean, 2);
        }

        private double getMean(IList<double> freqs)
        {
            double sum = 0;
            for (int i = 0; i < freqs.Count(); i++)
            {
                sum += (double)freqs[i] * i;
            }

            return sum;
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void prob1input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}