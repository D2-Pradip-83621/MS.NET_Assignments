namespace EmployeeLib
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public LinkedList<Employee> EmpList { get; set; }
        public double SalaryExpense { get; set; }

        // Default constructor
        public Company()
        {
            Name = string.Empty;
            Address = string.Empty;
            EmpList = new LinkedList<Employee>();
            SalaryExpense = 0;
        }

        // Parameterized constructor
        public Company(string name, string address)
        {
            Name = name;
            Address = address;
            EmpList = new LinkedList<Employee>();
            SalaryExpense = 0;
        }

        // Accept method to input data from the console
        public void Accept()
        {
            Console.Write("Enter company name: ");
            Name = Console.ReadLine();
            Console.Write("Enter company address: ");
            Address = Console.ReadLine();
        }

        // Print method to print data to the console
        public void Print()
        {
            Console.WriteLine($"Company Name: {Name}");
            Console.WriteLine($"Company Address: {Address}");
            Console.WriteLine($"Total Salary Expense: {SalaryExpense}");
            PrintEmployees();
        }

        // CalculateSalaryExpense method to calculate salary expense per month
        public void CalculateSalaryExpense()
        {
            SalaryExpense = 0;
            foreach (var employee in EmpList)
            {
                SalaryExpense += employee.Salary;
            }
        }

        // AddEmployee method to add an employee to the list
        public void AddEmployee(Employee e)
        {
            EmpList.AddLast(e);
            CalculateSalaryExpense();
        }

        // RemoveEmployee method to remove an employee by id
        public bool RemoveEmployee(int id)
        {
            var node = FindEmployee(id);
            if (node != null)
            {
                EmpList.Remove(node);
                CalculateSalaryExpense();
                return true;
            }
            return false;
        }

        // FindEmployee method to find an employee by id
        public LinkedListNode<Employee> FindEmployee(int id)
        {
            var current = EmpList.First;
            while (current != null)
            {
                if (current.Value.Id == id)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        // Override ToString method
        public override string ToString()
        {
            return $"Company Name: {Name}, Address: {Address}, Salary Expense: {SalaryExpense}";
        }

        // PrintEmployees method to print all employees
        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (var employee in EmpList)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
