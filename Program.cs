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
            Console.WriteLine("Welcome to Delicious Bakery register! Please start be entering the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());
            //Crete a list for employees

            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"\nEnter details for employee {i + 1}:");

                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());

                //create an Employee obj and add to the employees list
            }

            //Iterate over the employees list and show info for each one
        }
    }

}
