namespace DesignPattern.BehavioralDesignPattern.MementoDesignPattern
{
    public class Caretaker
    {
        private List<Memento> LedTvList = new List<Memento>();
        public void AddMemento(Memento m)
        {
            LedTvList.Add(m);
            Console.WriteLine("LED TV's snapshots Maintained by CareTaker :" + m.GetDetails());
        }
        public Memento GetMemento(int index)
        {
            return LedTvList[index];
        }
    }
}
