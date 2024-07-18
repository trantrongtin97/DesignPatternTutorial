using DesignPattern.StructuralDesignPattern.DecoratorDesignPattern.Interface;

namespace DesignPattern.StructuralDesignPattern.DecoratorDesignPattern
{
    public class ExampleDecoratorDesignPattern
    {
        public void Run()
        {
            IApplePhone phone = new XSVersion();
            phone.ManufactureApplePhone();
            Console.WriteLine(phone + "\n");

            XsMaxDecorator xsMaxDecorator = new XsMaxDecorator(phone);
            xsMaxDecorator.ManufactureApplePhone();
            Console.WriteLine(phone + "\n");
            Console.WriteLine();

            IApplePhone phone2 = new XSVersion();
            XsProMaxDecorator xsProMaxDecorator = new XsProMaxDecorator(phone2);
            xsProMaxDecorator.ManufactureApplePhone();
            Console.WriteLine(phone2 + "\n");
            Console.WriteLine();
        }
    }
}
