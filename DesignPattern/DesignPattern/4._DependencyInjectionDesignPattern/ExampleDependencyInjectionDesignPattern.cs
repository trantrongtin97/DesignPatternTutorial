using DesignPattern.DependencyInjectionDesignPattern.Interface;

namespace DesignPattern.DependencyInjectionDesignPattern
{
    public class ExampleDependencyInjectionDesignPattern
    {
        public ExampleDependencyInjectionDesignPattern() {
            TTTInjector.Map<IDataStorage, DataStorage>();
            TTTInjector.Map<IDemoService, DemoService>();
        }
        public void Run()
        {
            var dataStorage = TTTInjector.Get<IDataStorage>();
            dataStorage.Get(10);
            var service = TTTInjector.Get<IDemoService>();
            service.ShowData(11);
        }
    }
}
