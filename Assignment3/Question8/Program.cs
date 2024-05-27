using System.Net;
using System.Net.Http.Headers;
using System.Reflection;
using System.Transactions;
using System.Xml.Linq;

namespace Question8
{
    internal class Program
    {
          static void Main(string[] args)
            {
                Employee employee = new Employee();
                employee.acceptData();
                employee.printData();

            }
        }
    }
        public class Date
        {
            private int _Day;
            private int _Month;
            private int _Year;

            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }
            public Date()
            {

            }
            public Date(int day, int month, int year)
            {
                this.Day = day;
                this.Month = month;
                this.Year = year;
            }
            public static int AgeCalculator(Date birthDate)
            {
                DateTime todayDate = DateTime.Today;
                int age = todayDate.Year - birthDate.Year;
                return age;
            }
            public void AcceptDate()
            {
                Console.WriteLine("Enter Day");
                Day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Month");
                Month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Year");
                Year = Convert.ToInt32(Console.ReadLine());
            }
            public void PrintDate()
            {
                Console.WriteLine("Date of Birth: " + Day + "/" + Month + "/" + Year);
            }

        }
        public class Person
        {
            private string _Name;
            private bool _Gender;
            private Date _Birth;
            private string _Address;

            public Person()
            {
                this._Birth = new Date();
            }
            public Person(string Name, bool Gender, Date Birth, string Address)
            {
                this._Name = Name;
                this._Gender = Gender;
                this._Birth = Birth;
                this._Address = Address;
            }
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
            public bool Gender
            {
                get { return _Gender; }
                set { _Gender = value; }
            }

            public Date Birth
            {
                get { return _Birth; }
                set { _Birth = value; }
            }

            public string Address
            {
                get { return _Address; }
                set { _Address = value; }
            }
            public int Age
            {
                get { return Date.AgeCalculator(Birth); }
            }
            public void acceptData()
            {
                Console.Write("Enter name: ");
                Name = Console.ReadLine();
                Console.Write("Enter gender (true for male, false for female): ");
                Gender = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Enter Date of Birth");
                Birth.AcceptDate();
                Console.WriteLine("Enter your address: ");
                Address = Console.ReadLine();
            }
            public void printData()
            {
                Console.WriteLine(ToString());
            }


            public override string ToString()
            {
                return $"Name: {Name}, Gender: {(Gender ? "Male" : "Female")}, Birth Date: {Birth.Day}/{Birth.Month}/{Birth.Year}, Address: {Address}, Age: {Age}";
            }
        }
        public enum DeptName
        {
            HR,
            IT,
            Finance,
            Marketing,
            Sales
        }
        public class Employee : Person
        {
            private int count = 0;
            private int id;
            private double salary;
            private string designation;
            private DeptName dept;

            public int Id
            {
                get { return id; }
                private set { id = value; }
            }

            public double Salary
            {
                get { return salary; }
                set { salary = value; }
            }

            public string Designation
            {
                get { return designation; }
                set { designation = value; }
            }

            public DeptName Dept
            {
                get { return dept; }
                set { dept = value; }
            }
            public Employee()
            {
                Id = ++count;
            }
            public Employee(double salary, string designation, DeptName dept) : base()
            {
                Id = ++count;
                Salary = salary;
                Designation = designation;
                Dept = dept;
            }
            public void acceptData()
            {
                base.acceptData();
                Console.Write("Enter Salary: ");
                Salary = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Designation: ");
                Designation = Console.ReadLine();

                Console.Write("Enter Department (HR, IT, Finance, Marketing, Sales): ");
                Dept = (DeptName)Enum.Parse(typeof(DeptName), Console.ReadLine());
            }
            public void printData()
            {
                Console.WriteLine(ToString());
            }
            public override string ToString()
            {
                return base.ToString() + $", ID: {Id}, Salary: {Salary}, Designation: {Designation}, Department: {Dept}";
            }
        }


    

