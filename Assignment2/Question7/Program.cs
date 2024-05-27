using System.Net;
using System.Net.Http.Headers;
using System.Reflection;
using System.Xml.Linq;


namespace Question7
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Person person = new Person();
                person.AcceptPerson();
                person.PrintPerson();

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
            public void AcceptPerson()
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
            public void PrintPerson()
            {
                char genderPerson;
                Console.WriteLine("Name: " + Name);
                if (Gender == true)
                {
                    genderPerson = 'M';
                }
                else
                {
                    genderPerson = 'F';
                }
                Console.WriteLine("Gender: " + genderPerson);
                Birth.PrintDate();
                Console.WriteLine("Age: " + Age);
                Console.WriteLine("Address: " + Address);
            }

            public override string ToString()
            {
                return $"Name: {Name}, Gender: {(Gender ? "Male" : "Female")}, Birth Date: {Birth.Day}/{Birth.Month}/{Birth.Year}, Address: {Address}, Age: {Age}";
            }
        }
    }


