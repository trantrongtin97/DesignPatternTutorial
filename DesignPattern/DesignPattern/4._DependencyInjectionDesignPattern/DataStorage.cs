using DesignPattern.DependencyInjectionDesignPattern.Interface;

namespace DesignPattern.DependencyInjectionDesignPattern
{
    public class DataStorage : IDataStorage
    {
        public void Get(int id)
        {
            Console.WriteLine($"Get Data of Record Id: {id}");
        }
    }
}
