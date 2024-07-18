using DesignPattern.StructuralDesignPattern.AdapterDesignPattern.Interface;

namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    public class ExampleAdapterDesignPattern
    {
        dynamic[] list = new dynamic[] {
                new { Id = 1, Name = "TL", Salary = 10000, Dob = new DateTime(1995,07,21)},
                new { Id = 1, Name = "TT", Salary = 9000, Dob = new DateTime(1997,07,11)},
                new { Id = 1, Name = "NT", Salary = 4000, Dob = new DateTime(1996,06,07)},
                new { PropertyOne = true, PropertyTwo = false} };
        public void Run()
        {
            Console.WriteLine("Object Adapter Desing Pattern");
            RunObjectAdapter();
            Console.WriteLine("Class Adapter Desing Pattern");
            RunClassAdapter();
        }
        public void RunObjectAdapter()
        {
            ITarget target = new DesignPattern.StructuralDesignPattern.AdapterDesignPattern.ObjectAdapter.EmployeeAdapter();
            target.ComparisionProcessSalary(list);
        }
        public void RunClassAdapter()
        {
            ITarget target = new DesignPattern.StructuralDesignPattern.AdapterDesignPattern.ClassAdapter.EmployeeAdapter();
            target.ComparisionProcessSalary(list);
        }
    }
}
