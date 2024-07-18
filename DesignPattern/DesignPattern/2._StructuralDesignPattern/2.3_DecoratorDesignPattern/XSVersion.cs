using DesignPattern.StructuralDesignPattern.DecoratorDesignPattern.Interface;

namespace DesignPattern.StructuralDesignPattern.DecoratorDesignPattern
{
    public class XSVersion : IApplePhone
    {
        private string Name = "XS";
        public string Chip { get; set; }
        public string Body { get; set; }
        public int Memory { get; set; }
        public IApplePhone ManufactureApplePhone()
        {
            Chip = "IOS 10";
            Body = "Iron";
            return this;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Chip: {Chip}, Body: {Body}, Memory: {Memory} GB";
        }
    }
}
