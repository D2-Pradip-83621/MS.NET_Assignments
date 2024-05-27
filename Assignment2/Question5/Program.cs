using System.Xml.Linq;

namespace Question5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student[] students = CreateArray();

            AcceptInfo(students);

            PrintInfo(students);

            Student[] reversedStudents = new Student[students.Length];
            ReverseArray(students, reversedStudents);

            




        }

        public static Student[] CreateArray()
        {
            Console.Write("Enter the number of students: ");
            int n = int.Parse(Console.ReadLine());
            return new Student[n];
        }

        public static void AcceptInfo(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("Enter RollNo : ");
                int _rollNo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter name for student: ");
                string _Name = Console.ReadLine();

                Console.Write("Enter marks: ");
                double _marks = Convert.ToDouble(Console.ReadLine());


                students[i] = new Student(_rollNo, _Name, _marks);
            }
        }

        public static void PrintInfo(Student[] students)
        {
            Console.WriteLine("Student Information:");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static void ReverseArray(Student[] students, Student[] reversedStudents)
        {
            int n = students.Length;
            for (int i = 0; i < n; i++)
            {
                reversedStudents[i] = students[n - 1 - i];
            }

        }
    }




    public class Student
    {
        private int _rollNo;
        private string _Name;
        private double _marks;
       

        public Student()
        {

        }

        public Student(int rollNo, string name, double marks)
        {
            _rollNo = rollNo;
            _Name = name;
            _marks = marks;
        }


        public override string ToString()
        {
            return $"Roll No: {_rollNo}, Name: {_Name}, Marks: {_marks}";
        }


    }
}