namespace Q2
{
    internal class WageEmployee : Employee
    {
        private int hours;
        private int rate;

        public WageEmployee()
        {
        }

        public WageEmployee(int hours, int rate)
        {
            this.hours = hours;
            this.rate = rate;
            // Designation = "Wage";
        }

        public int Hours { get => hours; set => hours = value; }
        public int Rate { get => rate; set => rate = value; }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter hours: ");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate: ");
            rate = Convert.ToInt32(Console.ReadLine());
            Designation = "Wage";

        }

        public override void Print()
        {
            //base.Print();
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Hours: " + Hours);
            Console.WriteLine("Rate: " + Rate);
        }

        public override string ToString()
        {
            return Name + ", " + Designation + ", " + Hours + ", " + Rate;
        }

    }
}
