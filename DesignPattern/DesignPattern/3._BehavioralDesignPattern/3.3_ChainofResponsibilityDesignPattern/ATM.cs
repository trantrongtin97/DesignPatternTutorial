using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehavioralDesignPattern.ChainofResponsibilityDesignPattern
{
    public class ATM
    {
        private FiveThousandHandler fiveThousandHandler = new FiveThousandHandler();
        private TwoThousandHandler twoThousandHandler = new TwoThousandHandler();
        private OneThousandHandler oneThousandHandler = new OneThousandHandler();
        private OneHundredHandler oneHundredHandler = new OneHundredHandler();

        public ATM()
        {
            fiveThousandHandler.SetNextHandler(twoThousandHandler);
            twoThousandHandler.SetNextHandler(oneThousandHandler);
            oneThousandHandler.SetNextHandler(oneHundredHandler);
        }

        public void Withdraw(long requestedAmount)
        {
            if (requestedAmount % 100 == 0)
            {
                fiveThousandHandler.DispatchNote(requestedAmount);
            }
            else
            {
                Console.WriteLine($"You Enter Invalid Amount: {requestedAmount}");
            }
        }
    }
}
