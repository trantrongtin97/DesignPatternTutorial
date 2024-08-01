using DesignPattern.BehavioralDesignPattern.IteratorDesignPattern.Interface;

namespace DesignPattern.BehavioralDesignPattern.IteratorDesignPattern
{
    public class Iterator : IAbstractIterator
    {
        private TttCollection Collection;
        private int Current = 0;
        private readonly int Step = 1;

        public Iterator(TttCollection Collection)
        {
            this.Collection = Collection;
        }

        public Item First()
        {
            Current = 0;
            return Collection.GetItem(Current);
        }

        public Item Next()
        {
            Current += Step;
            if (!IsCompleted)
            {
                return Collection.GetItem(Current);
            }
            else
            {
                return null;
            }
        }

        public bool IsCompleted
        {
            get { return Current >= Collection.Count; }
        }
    }
}
