using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace lab14
{
    public class Client
    {
        public int TimeNeeded { get; set; }

        public Client()
        {
            Random rand = new Random();
            TimeNeeded = rand.Next(1, 10);
        }
    }
}
