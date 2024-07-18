using DesignPattern.FactoryDesignPattern.AbstractFactoryDesignPattern.Interface;
using DesignPattern.Object;
using DesignPattern.Object.Interface;

namespace DesignPattern.FactoryDesignPattern.AbstractFactoryDesignPattern
{
    public class RegularVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new RegularBike();
        }
        public ICar CreateCar()
        {
            return new RegularCar();
        }
    }
}
