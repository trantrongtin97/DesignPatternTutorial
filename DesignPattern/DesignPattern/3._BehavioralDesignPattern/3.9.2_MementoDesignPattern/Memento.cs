namespace DesignPattern.BehavioralDesignPattern.MementoDesignPattern
{
    public class Memento
    {
        public LEDTV LedTV { get; set; }
        public Memento(LEDTV ledTV)
        {
            LedTV = ledTV;
        }
        public string GetDetails()
        {
            return "Memento [LedTV=" + LedTV.GetDetails() + "]";
        }
    }
}
