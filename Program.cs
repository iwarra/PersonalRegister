namespace PersonalRegister
{

    class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string lastName, decimal salary)
        {
            Name = name;
            LastName = lastName;
            Salary = salary;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Delicious Bakery register! Please start by entering the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"\nEnter details for employee {i + 1}:");

                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());

                Employee employee = new Employee(firstName, lastName, salary);
                employees.Add(employee);
            }

            Console.WriteLine("\nHere is your employees list: ");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name} {employee.LastName}, Salary: {employee.Salary}");
            }
        }
    }

}
