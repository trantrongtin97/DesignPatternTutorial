namespace DesignPattern.Object
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Salary { get; set; }
        public DateTime? Dob { get; set; }
        public Employee() { }
        public Employee(int id, string name, double? salary, DateTime? dob)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Dob = dob;
        }
    }
}
