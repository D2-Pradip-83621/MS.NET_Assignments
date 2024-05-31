namespace Q2
{
    using System;

    public class Employee
    {
        private string name;
        private int age;
        private string designation;

        public Employee()
        {
            Designation = "Employee";
        }

        public Employee(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Designation { get => designation; set => designation = value; }

        public virtual void Accept()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Designation: {Designation}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Designation: {Designation}";
        }
    }

}