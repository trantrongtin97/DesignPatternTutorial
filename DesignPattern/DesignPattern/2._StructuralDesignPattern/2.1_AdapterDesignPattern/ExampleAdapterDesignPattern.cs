
namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    public class ExampleAdapterDesignPattern
    {
        string[,] list1 = new string[5, 4]
            {
                {"101","John","10000","1997-07-01"},
                {"102","Smith","20000","1995-02-01"},
                {"103","Dev","30000","1996-08-01"},
                {"104","Pam","40000","1999-03-01"},
                {"105","Sara","50000","1990-05-01"}
            };

        dynamic[] list2 = new dynamic[] {
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
            DesignPattern.StructuralDesignPattern.AdapterDesignPattern.ObjectAdapter.Interface.ITarget target = new DesignPattern.StructuralDesignPattern.AdapterDesignPattern.ObjectAdapter.EmployeeAdapter();
            target.ComparisionProcessSalary(list1);
        }
        public void RunClassAdapter()
        {
            DesignPattern.StructuralDesignPattern.AdapterDesignPattern.ClassAdapter.Interface.ITarget target = new DesignPattern.StructuralDesignPattern.AdapterDesignPattern.ClassAdapter.EmployeeAdapter();
            target.ComparisionProcessSalary(list2);
        }
    }
}
