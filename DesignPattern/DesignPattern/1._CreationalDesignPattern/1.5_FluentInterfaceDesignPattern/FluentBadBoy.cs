using DesignPattern.Object;

namespace DesignPattern.CreationalDesignPattern.FluentInterfaceDesignPattern
{
    public class FluentBadBoy
    {
        private BadBoy badBoy = new BadBoy();
        public FluentBadBoy NameOfBadBoy(string FullName)
        {
            badBoy.FullName = FullName;
            return this;
        }
        public FluentBadBoy Born(string DateOfBirth)
        {
            badBoy.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            return this;
        }
        public FluentBadBoy WorkingOn(string Department)
        {
            badBoy.Department = Department;
            return this;
        }
        public FluentBadBoy StaysAt(string Address)
        {
            badBoy.Address = Address;
            return this;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Name: {badBoy.FullName}, \nDateOfBirth: {badBoy.DateOfBirth}, \nDepartment: {badBoy.Department}, \nAddress: {badBoy.Address}");
        }
    }
}
