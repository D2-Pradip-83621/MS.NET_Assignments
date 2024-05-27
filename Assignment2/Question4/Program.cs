namespace Question4
{
    internal class Program
    {
      
            static void Main(string[] args)
            {
                Student student = new Student();
                student.acceptData();
                student.displayData();
            }
        }
        public class Student
        {
            private string _name;
            private string _gender;
            private int _age;
            private int _std;
            private char _div;
            private double _marks;

            public double marks
            {
                get { return _marks; }
                set { _marks = value; }
            }


            public char div
            {
                get { return _div; }
                set { _div = value; }
            }


            public int std
            {
                get { return _std; }
                set { _std = value; }
            }


            public int age
            {
                get { return _age; }
                set { _age = value; }
            }


            public string gender
            {
                get { return _gender; }
                set { _gender = value; }
            }


            public string name
            {
                get { return _name; }
                set { _name = value; }
            }
            public Student()
            {
                this.name = "Pradip";
                this.gender = "male";
                this.age = 18;
                this.std = 12;
                this.div = 'B';
                this.marks = 100;
            }
            public Student(string name, string gender, int age, int std, char div, double marks)
            {
                this.name = name;
                this.gender = gender;
                this.age = age;
                this.std = std;
                this.div = div;
                this.marks = marks;
            }
            public void acceptData()
            {
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                Console.WriteLine("Enter gender");
                gender = (Console.ReadLine());
                Console.WriteLine("Enter age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter std");
                std = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter div");
                div = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter marks");
                marks = Convert.ToDouble(Console.ReadLine());

            }
            public void displayData()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Gender: " + gender);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Standard: " + std);
                Console.WriteLine("Division: " + div);
                Console.WriteLine("Marks: " + marks);
            }

        }
    }


