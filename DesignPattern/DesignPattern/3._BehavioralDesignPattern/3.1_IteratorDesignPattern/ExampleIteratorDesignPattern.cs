namespace DesignPattern.BehavioralDesignPattern.IteratorDesignPattern
{
    public class ExampleIteratorDesignPattern
    {
        public void Run()
        {
            TttCollection collection = new TttCollection();
            collection.AddItem(new Item(1, "aaa"));
            collection.AddItem(new Item(2, "bbb"));
            collection.AddItem(new Item(3, "ccc"));
            collection.AddItem(new Item(4, "ddd"));

            Iterator iterator = collection.CreateIterator();
            for (Item item = iterator.First(); !iterator.IsCompleted; item = iterator.Next())
            {
                Console.WriteLine($"ID : {item.Id} & Name : {item.Name}");
            }
        }
    }
}
