using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehavioralDesignPattern.MementoDesignPattern
{
    public class ExampleMementoDesignPattern
    {
        public void Run()
        {
            Originator originator = new Originator
            {
                LedTV = new LEDTV("42-Inch", "60000", false)
            };
            Caretaker caretaker = new Caretaker();
            Memento memento = originator.CreateMemento();
            caretaker.AddMemento(memento);
            originator.LedTV = new LEDTV("46-Inch", "80000", true);
            memento = originator.CreateMemento();
            caretaker.AddMemento(memento);
            originator.LedTV = new LEDTV("50-Inch", "100000", true);
            Console.WriteLine("\nOrignator Current State : " + originator.GetDetails());
            Console.WriteLine("\nOriginator Restoring to 42-Inch LED TV");
            originator.SetMemento(caretaker.GetMemento(0));
            Console.WriteLine("\nOrignator Current State : " + originator.GetDetails());
        }
    }
}
