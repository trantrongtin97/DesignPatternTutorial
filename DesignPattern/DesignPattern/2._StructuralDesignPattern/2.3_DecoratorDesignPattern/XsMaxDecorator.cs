using DesignPattern.StructuralDesignPattern.DecoratorDesignPattern.Interface;

namespace DesignPattern.StructuralDesignPattern.DecoratorDesignPattern
{
    public class XsMaxDecorator : AppleDecorator
    {
        public XsMaxDecorator(IApplePhone phone) : base(phone)
        {
        }

        public override IApplePhone ManufactureApplePhone()
        {
            phone.ManufactureApplePhone();
            AddMemory(phone);
            return phone;
        }

        public void AddMemory(IApplePhone phone)
        {
            if (phone is XSVersion xsVersion)
            {
                xsVersion.Memory = 128;
                Console.WriteLine("Xs Max added to the phone");
            }
        }
    }
}
