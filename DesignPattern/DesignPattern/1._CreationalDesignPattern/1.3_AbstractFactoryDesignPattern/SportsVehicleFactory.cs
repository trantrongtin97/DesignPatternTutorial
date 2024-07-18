using DesignPattern.FactoryDesignPattern.AbstractFactoryDesignPattern.Interface;
using DesignPattern.Object;
using DesignPattern.Object.Interface;

namespace DesignPattern.FactoryDesignPattern.AbstractFactoryDesignPattern
{
    public class SportsVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new SportBike();
        }
        public ICar CreateCar()
        {
            return new SportCar();
        }
    }
}
