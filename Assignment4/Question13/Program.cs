using EmployeeLib;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.Accept();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. Find Employee by ID");
                Console.WriteLine("4. Display Company Info");
                Console.WriteLine("5. Display All Employees");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddEmployee(company);
                        break;
                    case 2:
                        RemoveEmployee(company);
                        break;
                    case 3:
                        FindEmployee(company);
                        break;
                    case 4:
                        company.Print();
                        break;
                    case 5:
                        company.PrintEmployees();
                        break;
                    case 6:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddEmployee(Company company)
        {
            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Employee employee = new Employee(id, name, salary);
            company.AddEmployee(employee);
            Console.WriteLine("Employee added successfully.");
        }

        static void RemoveEmployee(Company company)
        {
            Console.Write("Enter Employee ID to remove: ");
            int id = int.Parse(Console.ReadLine());

            bool result = company.RemoveEmployee(id);
            if (result)
            {
                Console.WriteLine("Employee removed successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        static void FindEmployee(Company company)
        {
            Console.Write("Enter Employee ID to find: ");
            int id = int.Parse(Console.ReadLine());

            var node = company.FindEmployee(id);
            if (node != null)
            {
                Console.WriteLine($"Employee found: {node.Value}");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }
}
