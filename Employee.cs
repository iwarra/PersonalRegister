
namespace PersonalRegister
{
    internal class Employee(string name, string lastName, decimal salary)
    {
        public string Name { get; set; } = name;
        public string LastName { get; set; } = lastName;
        public decimal Salary { get; set; } = salary;
    }
}
