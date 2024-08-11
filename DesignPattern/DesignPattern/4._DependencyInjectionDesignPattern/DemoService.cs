using DesignPattern.DependencyInjectionDesignPattern.Interface;

namespace DesignPattern.DependencyInjectionDesignPattern
{
    public class DemoService : IDemoService
    {
        private IDataStorage _dataStorage;

        public DemoService(IDataStorage dataStorage)
        {
            _dataStorage = dataStorage;
        }


        public void ShowData(int id)
        {
            if (id == 0)
            {
                throw new ArgumentException("Id is requied");
            }

            _dataStorage.Get(id);
        }
    }
}
    