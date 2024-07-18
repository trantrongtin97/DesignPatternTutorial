using DesignPattern.Object;
using DesignPattern.StructuralDesignPattern.AdapterDesignPattern.Interface;
using System.Reflection;

namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern.ObjectAdapter
{
    public class EmployeeAdapter : ITarget
    {
        public BusinessLayerService service = new BusinessLayerService();
        public void ComparisionProcessSalary(dynamic[] arrEmployee)
        {
            List<Employee> employees = new List<Employee>();
            foreach (dynamic item in arrEmployee)
            {
                employees.Add(new Employee(GetValueObject(item, "Id") ?? 0, GetValueObject(item, "Name") ?? string.Empty, GetValueObject(item, "Salary") ?? 0, GetValueObject(item, "Dob") ?? DateTime.MinValue));
            }
            service.ProcessSalary(employees);
        }
        private object? GetValueObject(dynamic obj, string property)
        {
            try
            {
                return (GetPropertyValid(property)) ? obj.GetType().GetProperty(property).GetValue(obj, null) : null;
            }
            catch
            {
                return null;
            }
            
        }
        private bool GetPropertyValid(string property)
        {
            PropertyInfo[] lsProperty = new Employee().GetType().GetProperties();
            foreach (PropertyInfo s in lsProperty)
            {
                if (property == s.Name)
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckPropertyNullable(Type type)
        {
            return (Nullable.GetUnderlyingType(type) != null);
        }
    }
}
