using DesignPattern.Object.Interface;

namespace DesignPattern.Object
{
    public class RegularCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("RegularCar Details..");
        }
    }
}
