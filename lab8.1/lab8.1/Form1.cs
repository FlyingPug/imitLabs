namespace lab8._1
{
    public partial class Form1 : Form
    {
        private readonly (string, double)[] eventProbabilities = {
            ("Сто процентов", 0.1),
            ("Ручаюсь", 0.15),
            ("Скорее всего", 0.05),
            ("Да", 0.1),
            ("По всей видимости", 0.1),
            ("Весьма сомнительно", 0.1),
            ("ХЗ", 0.1),
            ("Мне то откуда знать?", 0.05),
            ("Нет", 0.1),
            ("Нет.", 0.05),
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