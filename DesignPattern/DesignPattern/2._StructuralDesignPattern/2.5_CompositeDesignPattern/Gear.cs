using DesignPattern.StructuralDesignPattern.CompositeDesignPattern.Interface;

namespace DesignPattern.StructuralDesignPattern.CompositeDesignPattern
{
    public class Gear : IComponent
    {
        public string Name { get; set; }    
        public double Price { get; set; }
        public Gear(string name,double price) 
        { 
            this.Name = name;
            this.Price = price;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Component name: {Name}, Price: {Price}");
        }
    }
}
