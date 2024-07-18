using DesignPattern.StructuralDesignPattern.CompositeDesignPattern.Interface;

namespace DesignPattern.StructuralDesignPattern.CompositeDesignPattern
{
    public class ExampleCompositeDesignPattern
    {
        public void Run()
        {
            IComponent hardDisk = new Gear("Hard Disk", 2000);
            IComponent ram = new Gear("RAM", 3000);
            IComponent cpu = new Gear("CPU", 2000);
            IComponent mouse = new Gear("Mouse", 2000);
            IComponent keyboard = new Gear("Keyboard", 2000);

            Composite motherBoard = new Composite("MotherBoard");
            Composite cabinet = new Composite("Cabinet");
            Composite peripherals = new Composite("Peripherals");
            Composite computer = new Composite("Computer");

            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);

            cabinet.AddComponent(motherBoard);
            cabinet.AddComponent(hardDisk);

            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);

            computer.AddComponent(cabinet);
            computer.AddComponent(peripherals);

            Console.WriteLine("Price of Computer Composite Components");
            computer.ShowInfo();

            Console.WriteLine("\nPrice of Keyboard Child or Gear Component:");
            keyboard.ShowInfo();

            Console.WriteLine("\nPrice of Cabinet Composite Component:");
            cabinet.ShowInfo();
        }
    }
}
