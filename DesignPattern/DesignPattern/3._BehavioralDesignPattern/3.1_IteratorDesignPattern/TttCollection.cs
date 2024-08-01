using DesignPattern.BehavioralDesignPattern.IteratorDesignPattern.Interface;

namespace DesignPattern.BehavioralDesignPattern.IteratorDesignPattern
{
    public class TttCollection : IAbstractCollection
    {
        private List<Item> listItem = new List<Item>();
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return listItem.Count; }
        }

        public void AddItem(Item item)
        {
            listItem.Add(item);
        }

        public Item GetItem(int IndexPosition)
        {
            return listItem[IndexPosition];
        }
    }
}
