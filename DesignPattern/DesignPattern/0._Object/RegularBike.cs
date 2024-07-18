using DesignPattern.Object.Interface;

namespace DesignPattern.Object
{
    public class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("RegularBike Details..");
        }
    }
}
