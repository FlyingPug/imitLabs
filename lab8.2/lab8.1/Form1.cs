namespace lab8._1
{
    public partial class Form1 : Form
    {
        private readonly (string, double)[] eventProbabilities = {
            ("��� ���������", 0.1),
            ("�������", 0.15),
            ("������ �����", 0.05),
            ("��", 0.1),
            ("�� ���� ���������", 0.1),
            ("������ �����������", 0.1),
            ("��", 0.1),
            ("��� �� ������ �����?", 0.05),
            ("���", 0.1),
            ("���.", 0.05),
            ("NEIN!", 0.1)
        };

        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MakePrediction();
        }

        private void MakePrediction()
        {
            double P = random.NextDouble();

            foreach ((string answer, double probability) in eventProbabilities)
            {
                P -= probability;
                if (P <= 0)
                {
                    Answer.Text = answer;
                    break;
                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MakePrediction();
        }
    }
}