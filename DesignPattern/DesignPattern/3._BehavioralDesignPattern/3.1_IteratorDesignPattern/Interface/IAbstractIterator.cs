namespace DesignPattern.BehavioralDesignPattern.IteratorDesignPattern.Interface
{
    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsCompleted { get; }
    }
}
