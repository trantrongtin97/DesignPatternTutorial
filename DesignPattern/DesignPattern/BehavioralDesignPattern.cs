using DesignPattern.BehavioralDesignPattern.IteratorDesignPattern;

namespace DesignPattern.BehavioralDesignPattern
{
    public class BehavioralDesignPattern
    {
        public void Basic()
        {
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("********************************** Behavioral Design Pattern ****************************************");

            ExampleIteratorDesignPattern exampleIteratorDesignPattern = new ExampleIteratorDesignPattern();
            exampleIteratorDesignPattern.Run();
        }
    }
}
