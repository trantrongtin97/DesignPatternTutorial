namespace DesignPattern.BehavioralDesignPattern.ChainofResponsibilityDesignPattern
{
    internal class OneThousandHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 1000;
            if (numberofNotesToBeDispatched > 0)
            {
                Console.WriteLine($"One Thousand Dispatched : {numberofNotesToBeDispatched}");
            }

            long pendingAmountToBeProcessed = requestedAmount % 1000;

            if (pendingAmountToBeProcessed > 0)
            {
                NextHandler.DispatchNote(pendingAmountToBeProcessed);
            }
        }
    }
}
