using DesignPattern.BehavioralDesignPattern.ChainofResponsibilityDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehavioralDesignPattern.ChainofResponsibilityDesignPattern
{
    internal class OneHundredHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 100;
            if (numberofNotesToBeDispatched > 0)
            {
                Console.WriteLine($"One Hundred Dispatched : {numberofNotesToBeDispatched}");
            }
        }
    }
}
