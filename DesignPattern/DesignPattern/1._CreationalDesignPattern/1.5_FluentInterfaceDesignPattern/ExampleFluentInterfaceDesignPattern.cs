namespace DesignPattern.FactoryDesignPattern.FluentInterfaceDesignPattern
{
    public class ExampleFluentInterfaceDesignPattern
    {
        public void Run()
        {
            FluentBadBoy obj = new FluentBadBoy();
            obj.NameOfBadBoy("TranTin")
                    .Born("11/07/1997")
                    .WorkingOn("IT")
                    .StaysAt("HCM-VN");
            obj.ShowDetails();
        }
    }
}
