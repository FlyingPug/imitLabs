using System.Xml;

namespace lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double[,] Q =
        { 
            {-0.4, 0.3,0.1},
            {0.4,-0.8,0.4},
            {0.1,0.4,-0.5}
        };
        int state = 0;
        double t = 0;
        double totalT = 0;
        Random random = new Random();
        double[] stationaryDistribution = new double[3];
        private void timer1_Tick(object sender, EventArgs e)
        {
            t += timer1.Interval;
            int i = getNextState(Q, state);
            if (i != state)
            {
                stationaryDistribution[i] += t;
                totalT += t;
                t = 0;
                state = i;

                showPicture();
                updateTable();
            }
        }

        private void updateTable()
        {
            for(int i = 0; i < stationaryDistribution.Length; i++) 
            {
                if (DataResult.Rows.Count <= i) DataResult.Rows.Add(0, 0);
                DataResult.Rows[i].Cells[0].Value = stationaryDistribution[i] / totalT;
            }
        }

        private void showPicture()
        {
            switch(state)
            {
                case 0:
                    pictureBox.Image = Image.FromFile("images/sunny.png");
                    break;
                case 1:
                    pictureBox.Image = Image.FromFile("images/rainy.png");
                    break;
                case 2:
                    pictureBox.Image = Image.FromFile("images/cloudy.png");
                    break;
                default:
                    pictureBox.Image = Image.FromFile("images/rainbow.png");
                    break;
            }
        }

        private int getNextState(double[,] Q, int currentState)
        {
            double sum = 0;

            double a = random.NextDouble();
            for (int i = 0; i < Q.GetLength(0); i++)
            {
                sum += Math.Abs(Q[currentState, i]);

                if (a < sum) return i;
            }

            return Q.GetLength(0) - 1;
        }
    }
}
