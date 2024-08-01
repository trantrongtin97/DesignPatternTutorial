using DesignPattern.Object.Interface;

namespace DesignPattern.CreationalDesignPattern.AbstractFactoryDesignPattern.Interface
{
    public interface IVehicleFactory
    {
        IBike CreateBike();
        ICar CreateCar();
    }
}
