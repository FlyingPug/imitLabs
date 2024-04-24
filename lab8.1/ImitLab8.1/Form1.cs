namespace ImitLab8._1
{
    public partial class Form1 : Form
    {
        private const int prob = 50;
        public Form1()
        {
            InitializeComponent();

            Random rand = new Random();

            Answer.Text = rand.Next(100) > prob ? "Да" : "Нет";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}