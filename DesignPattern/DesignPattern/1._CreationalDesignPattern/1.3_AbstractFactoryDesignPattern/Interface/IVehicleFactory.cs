using DesignPattern.Object.Interface;

namespace DesignPattern.FactoryDesignPattern.AbstractFactoryDesignPattern.Interface
{
    public interface IVehicleFactory
    {
        IBike CreateBike();
        ICar CreateCar();
    }
}
