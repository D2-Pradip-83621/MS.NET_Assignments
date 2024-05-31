namespace Q3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Company company = new Company("Tech Solutions", "123 Tech Street");

            Employee emp1 = new Employee(1, "John Doe", 5000);
            Employee emp2 = new Employee(2, "Jane Smith", 6000);
            Employee emp3 = new Employee(3, "Bob Johnson", 7000);

            company.AddEmployee(emp1);
            company.AddEmployee(emp2);
            company.AddEmployee(emp3);

            company.Print();

            Console.WriteLine("\nRemoving employee with ID 2.");
            company.RemoveEmployee(2);

            company.Print();
        }
    }

}
