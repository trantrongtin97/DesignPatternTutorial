namespace DesignPattern.BehavioralDesignPattern.MementoDesignPattern
{
    public class Originator
    {
        public LEDTV LedTV;
        public Memento CreateMemento()
        {
            return new Memento(LedTV);
        }
        public void SetMemento(Memento memento)
        {
            LedTV = memento.LedTV;
        }
        public string GetDetails()
        {
            return "Originator [LEDTV=" + LedTV.GetDetails() + "]";
        }
    }
}
