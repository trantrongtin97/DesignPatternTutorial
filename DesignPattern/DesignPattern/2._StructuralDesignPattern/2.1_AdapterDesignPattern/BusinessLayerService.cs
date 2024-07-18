using DesignPattern.Object;

namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    public class BusinessLayerService
    {
        public void ProcessSalary(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Employee : {employee.Name} : ${employee.Salary}");
            }
        }
    }
}
