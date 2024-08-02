namespace DesignPattern.BehavioralDesignPattern.ChainofResponsibilityDesignPattern
{
    public class TwoThousandHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 2000;
            if (numberofNotesToBeDispatched > 0)
            {
                Console.WriteLine($"Two Thousand Dispatched : {numberofNotesToBeDispatched}");
            }

            long pendingAmountToBeProcessed = requestedAmount % 2000;

            if (pendingAmountToBeProcessed > 0)
            {
                NextHandler.DispatchNote(pendingAmountToBeProcessed);
            }
        }
    }
}
