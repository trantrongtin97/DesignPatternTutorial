using DesignPattern.StructuralDesignPattern.AdapterDesignPattern;
using DesignPattern.StructuralDesignPattern.BridgeDesignPattern;
using DesignPattern.StructuralDesignPattern.CompositeDesignPattern;
using DesignPattern.StructuralDesignPattern.DecoratorDesignPattern;
using DesignPattern.StructuralDesignPattern.FacadeDesignPattern;
using DesignPattern.StructuralDesignPattern.FlyweightDesignPattern;
using DesignPattern.StructuralDesignPattern.ProxyDesignPattern.CacheProxyDesignPattern;
using DesignPattern.StructuralDesignPattern.ProxyDesignPattern.FireWallProxyDesignPattern;
using DesignPattern.StructuralDesignPattern.ProxyDesignPattern.LoggingProxyDesignPattern;
using DesignPattern.StructuralDesignPattern.ProxyDesignPattern.RemoteProxyDesignPattern;
using DesignPattern.StructuralDesignPattern.ProxyDesignPattern.SmartReferenceProxyDesignPattern;
using DesignPattern.StructuralDesignPattern.ProxyDesignPattern.SynchronizationProxyDesignPattern;
using DesignPattern.StructuralDesignPattern.ProxyDesignPattern.VirtualProxyDesignPattern;

namespace DesignPattern.StructuralDesignPattern
{
    public class StructuralDesignPattern
    {
        public async Task BasicAsync()
        {
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("********************************** Structural Design Pattern ****************************************");

            ExampleAdapterDesignPattern exampleAdapterDesignPattern = new ExampleAdapterDesignPattern();
            exampleAdapterDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleFacadeDesignPattern exampleFacadeDesignPattern = new ExampleFacadeDesignPattern();
            exampleFacadeDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleDecoratorDesignPattern exampleDecoratorDesignPattern = new ExampleDecoratorDesignPattern();
            exampleDecoratorDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleBridgeDesignPattern exampleBridgeDesignPattern = new ExampleBridgeDesignPattern();
            exampleBridgeDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleCompositeDesignPattern exampleCompositeDesignPattern = new ExampleCompositeDesignPattern();
            exampleCompositeDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleFlyweightDesignPattern exampleFlyweightDesignPattern = new ExampleFlyweightDesignPattern();
            exampleFlyweightDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleVirsualProxyDesignPattern exampleVirsualProxyDesignPattern = new ExampleVirsualProxyDesignPattern();
            exampleVirsualProxyDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleRemoteProxyDesignPattern exampleRemoteProxyPattern = new ExampleRemoteProxyDesignPattern();
            exampleRemoteProxyPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleCacheProxyDesignPattern exampleCacheProxyDesignPattern = new ExampleCacheProxyDesignPattern();
            exampleCacheProxyDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleLoggingProxyDesignPattern exampleLoggingProxyDesignPattern = new ExampleLoggingProxyDesignPattern();
            exampleLoggingProxyDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleSynchronizationProxyDesignPattern exampleSynchronizationProxyDesignPattern = new ExampleSynchronizationProxyDesignPattern();
            await exampleSynchronizationProxyDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleFireWallProxyDesignPattern exampleFireWallProxyDesignPattern = new ExampleFireWallProxyDesignPattern();
            exampleFireWallProxyDesignPattern.Run();

            Console.WriteLine("**************************************************************************************************");
            ExampleSmartReferenceProxyDesignPattern exampleSmartReferenceProxyDesignPattern = new ExampleSmartReferenceProxyDesignPattern();
            exampleSmartReferenceProxyDesignPattern.Run();
        }
    }
}
