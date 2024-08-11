using DesignPattern.Object;
using DesignPattern.StructuralDesignPattern.AdapterDesignPattern.ObjectAdapter.Interface;

namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern.ObjectAdapter
{
    public class EmployeeAdapter : ITarget
    {
        BusinessLayerService businessLayerService = new BusinessLayerService();
        public void ComparisionProcessSalary(string[,] employeesArray)
        {
            string id = null;
            string name = null;
            string salary = null;
            string dob = null;
            List<Employee> listEmployee = new List<Employee>();
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                for (int j = 0; j < employeesArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        id = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        name = employeesArray[i, j];
                    }
                    else if (j == 2)
                    {
                        salary = employeesArray[i, j];
                    }
                    else
                    {
                        dob = employeesArray[i, j];
                    }
                }
                listEmployee.Add(new Employee(Convert.ToInt32(id), name, Convert.ToDouble(salary), Convert.ToDateTime(dob)));
            }
            businessLayerService.ProcessSalary(listEmployee);
        }
    }
}
