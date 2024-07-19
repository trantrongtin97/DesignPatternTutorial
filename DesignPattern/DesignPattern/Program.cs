using DesignPattern.FactoryDesignPattern.AbstractFactoryDesignPattern;
using DesignPattern.FactoryDesignPattern.BuilderDesignPattern;
using DesignPattern.FactoryDesignPattern.FactoryMethodDesignPattern;
using DesignPattern.FactoryDesignPattern.FluentInterfaceDesignPattern;
using DesignPattern.FactoryDesignPattern.SimpleFactoryDesignPattern;
using DesignPattern.FactoryDesignPattern.SingletonDesignPattern.SimpleSingletonDesignPattern;
using DesignPattern.FactoryDesignPattern.SingletonDesignPattern.ThreadSafeSingletonDesignPattern;
using DesignPattern.StructuralDesignPattern.AdapterDesignPattern;
using DesignPattern.StructuralDesignPattern.BridgeDesignPattern;
using DesignPattern.StructuralDesignPattern.CompositeDesignPattern;
using DesignPattern.StructuralDesignPattern.DecoratorDesignPattern;
using DesignPattern.StructuralDesignPattern.FacadeDesignPattern;
using DesignPattern.StructuralDesignPattern.FlyweightDesignPattern;
using DesignPattern.StructuralDesignPattern.ProxyDesignPattern.CacheProxyDesignPattern;
using DesignPattern.StructuralDesignPattern.ProxyDesignPattern.LoggingProxyDesignPattern;
using DesignPattern.StructuralDesignPattern.ProxyDesignPattern.RemoteProxyDesignPattern;
using DesignPattern.StructuralDesignPattern.ProxyDesignPattern.VirtualProxyDesignPattern;

ExampleSimpleFactoryDesignPattern exampleSimpleFactoryDesignPattern = new ExampleSimpleFactoryDesignPattern();
exampleSimpleFactoryDesignPattern.Run();

Console.WriteLine("**************************************************************************************************");

ExampleFactoryMethodDesignPattern exampleFactoryMethodDesignPattern = new ExampleFactoryMethodDesignPattern();
exampleFactoryMethodDesignPattern.Run();

Console.WriteLine("**************************************************************************************************");

ExampleAbstractFactoryDesignPattern exampleAbstractFactoryDesignPattern = new ExampleAbstractFactoryDesignPattern();
exampleAbstractFactoryDesignPattern.Run();

Console.WriteLine("**************************************************************************************************");

ExampleBuilderDesignPattern exampleBuilderDesignPattern = new ExampleBuilderDesignPattern();
exampleBuilderDesignPattern.Run();

Console.WriteLine("**************************************************************************************************");

ExampleFluentInterfaceDesignPattern exampleFluentInterfaceDesignPattern = new ExampleFluentInterfaceDesignPattern();
exampleFluentInterfaceDesignPattern.Run();

Console.WriteLine("**************************************************************************************************");

ExampleSimpleSingletonDesignPattern exampleSimpleSingletonDesignPattern = new ExampleSimpleSingletonDesignPattern();
exampleSimpleSingletonDesignPattern.Run();

Console.WriteLine("**************************************************************************************************");

ExampleThreadSafeSingletonDesignPattern.Run();

Console.WriteLine("**************************************************************************************************");
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