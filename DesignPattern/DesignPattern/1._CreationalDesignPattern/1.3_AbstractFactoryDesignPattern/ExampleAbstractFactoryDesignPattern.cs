using DesignPattern.CreationalDesignPattern.AbstractFactoryDesignPattern.Interface;
using DesignPattern.Object.Interface;

namespace DesignPattern.CreationalDesignPattern.AbstractFactoryDesignPattern
{
    public class ExampleAbstractFactoryDesignPattern
    {
        public void Run()
        {
            IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();
            IBike regularBike = regularVehicleFactory.CreateBike();
            regularBike.GetDetails();
            ICar regularCar = regularVehicleFactory.CreateCar();
            regularCar.GetDetails();
            IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();
            IBike sportsBike = sportsVehicleFactory.CreateBike();
            sportsBike.GetDetails();
            ICar sportsCar = sportsVehicleFactory.CreateCar();
            sportsCar.GetDetails();
        }
    }
}
