namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WageEmployee we = new WageEmployee();
            we.Accept();
            we.Print();
            Console.WriteLine("-------------------------------");
            Console.WriteLine(we.ToString());
        }
    }
}
