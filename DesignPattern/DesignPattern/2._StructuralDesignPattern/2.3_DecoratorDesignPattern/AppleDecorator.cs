using DesignPattern.StructuralDesignPattern.DecoratorDesignPattern.Interface;

namespace DesignPattern.StructuralDesignPattern.DecoratorDesignPattern
{
    public class AppleDecorator : IApplePhone
    {
        protected IApplePhone phone;

        public AppleDecorator(IApplePhone phone)
        {
            this.phone = phone;
        }
        public virtual IApplePhone ManufactureApplePhone()
        {
            return phone.ManufactureApplePhone();
        }
    }
}
