//namespace Q3
//{
//    internal class Company
//    {
//        private string name;
//        private string address;
//        private LinkedList<Emp> empList;
//        private double salaryExpense;

//        public Company() { }

//        Emp e = new Emp();

//        public Company(string name, string address, LinkedList<Emp> empList, double salaryExpense)
//        {
//            this.name = name;
//            this.address = address;
//            this.empList = empList;
//            this.salaryExpense = salaryExpense;
//        }

//        public void accept()
//        {
//            Console.WriteLine("Enter name: ");
//            name = Console.ReadLine();

//            Console.WriteLine("Enter address: ");
//            address = Console.ReadLine();

//            Console.WriteLine("Enter name: ");
//            //empList = Console.ReadLine();

//        }

//        public string getName()
//        {
//            return name;
//        }

//        public string getAddress()
//        {
//            return address;
//        }
//        public LinkedList<Emp> getEmpList()
//        {
//            return empList;
//        }
//        public double getSalaryExpense()
//        {
//            return salaryExpense;
//        }


//        public void calculateSalary()
//        {
//            salaryExpense = empList.Count * e.Salary;
//        }


//    }

//    public class Emp
//    {
//        private string name;
//        private double salary;

//        public Emp() { }
//        public Emp(string name, double salary)
//        {
//            this.name = name;
//            this.salary = salary;
//        }

//        public string Name { get => name; set => name = value; }
//        public double Salary { get => salary; set => salary = value; }

//    }
//}



namespace Q3
{
    using System;
    using System.Collections.Generic;

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