using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    public class Operator
    {
        bool isBusy;
        private Panel vizual;
        public Client currentClient = new Client();

        public bool IsBusy { get { return isBusy; } }

        public Operator(Panel vizual)
        {
            isBusy = false;
            this.vizual = vizual;
        }

        public void StartProcessing(Client client)
        {
            currentClient = client;
            isBusy = true;
            vizual.BackColor = Color.Red;
        }

        public void ProcessEvent()
        {
            if (isBusy && currentClient.TimeNeeded <= 0)
            {
                isBusy = false;
                vizual.BackColor = Color.Green;
            }
            else
            {
                currentClient.TimeNeeded--;
            }
        }
    }
}