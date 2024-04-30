using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                currentPrice1 = (double)inputPrice1.Value;
                currentPrice2 = (double)inputPrice2.Value;
                MyChart.Series[0].Points.Clear();
                MyChart.Series[1].Points.Clear();
                counter = 0;
                timer1.Start();
            }
        }

        const double k = 0.02;
        Random rnd = new Random();
        const double mu = 0.1; // Drift coefficient
        const double sigma = 0.2; // Volatility coefficient
        const double dt = 0.01;
        double currentPrice1;
        double currentPrice2;
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            double Z1 = generateStandardNormalRandom();
            double Z2 = generateStandardNormalRandom();

            double nextPrice1 = currentPrice1 * Math.Exp((mu - 0.5 * sigma * sigma) * dt + sigma * Math.Sqrt(dt) * Z1);
            double nextPrice2 = currentPrice2 * Math.Exp((mu - 0.5 * sigma * sigma) * dt + sigma * Math.Sqrt(dt) * Z2);

            MyChart.Series[0].Points.AddXY(counter, nextPrice1);
            MyChart.Series[1].Points.AddXY(counter, nextPrice2);

            currentPrice1 = nextPrice1;
            currentPrice2 = nextPrice2;

            counter++;
        }

        private double generateStandardNormalRandom()
        {
            double u1 = 1.0 - rnd.NextDouble();
            double u2 = 1.0 - rnd.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
            return randStdNormal;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void MyChart_Click(object sender, EventArgs e)
        {

        }
    }
}