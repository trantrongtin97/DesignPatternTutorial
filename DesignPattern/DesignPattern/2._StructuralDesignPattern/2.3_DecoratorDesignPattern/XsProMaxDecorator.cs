using DesignPattern.StructuralDesignPattern.DecoratorDesignPattern.Interface;

namespace DesignPattern.StructuralDesignPattern.DecoratorDesignPattern
{
    public class XsProMaxDecorator : AppleDecorator
    {
        public XsProMaxDecorator(IApplePhone phone) : base(phone)
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
                xsVersion.Memory = 256;
                Console.WriteLine("Xs Pro Max added to the phone");
            }
        }
    }
}
