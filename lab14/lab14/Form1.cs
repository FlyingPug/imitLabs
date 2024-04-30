namespace lab14
{
    public partial class Form1 : Form
    {
        List<Operator> operators = new List<Operator>();
        Queue<Client> clients = new Queue<Client>();
        public Form1()
        {
            InitializeComponent();

            operators.Add(new Operator(panel1));
            operators.Add(new Operator(panel2));
            operators.Add(new Operator(panel3));
            operators.Add(new Operator(panel4));
            operators.Add(new Operator(panel5));

            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int GetValue(double lambda)
        {
            double S = 0;
            int m = 0;
            Random random = new Random();

            while (S >= -lambda)
            {
                S += Math.Log(random.NextDouble());
                m++;
            }
            return m;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clients.Count == 0)
            {
                for (int i = 0; i < GetValue(operators.Count); i++)
                {
                    clients.Enqueue(new Client());
                }
            }

            ClinetsInLine.Text = clients.Count.ToString();

            foreach (Operator op in operators) 
            {
                if(op.IsBusy)
                {
                    op.ProcessEvent();
                }
                else
                {
                    if(clients.Count > 0)
                    op.StartProcessing(clients.Dequeue());
                }
            }
        }
    }
}
