namespace DesignPattern.BehavioralDesignPattern.ChainofResponsibilityDesignPattern
{
    public class FiveThousandHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 5000;
            if (numberofNotesToBeDispatched > 0)
            {
                Console.WriteLine($"Five Thousand Dispatched : {numberofNotesToBeDispatched}");
            }

            long pendingAmountToBeProcessed = requestedAmount % 2000;

            if (pendingAmountToBeProcessed > 0)
            {
                NextHandler.DispatchNote(pendingAmountToBeProcessed);
            }
        }
    }
}
