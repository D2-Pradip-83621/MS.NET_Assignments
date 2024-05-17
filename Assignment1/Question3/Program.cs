using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu()
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Substraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("Enter Your Choice");
                int value = Convert.ToInt32(Console.ReadLine());
                return value;

            }



            int choice;
            while ((choice = menu()) != 0)
            {

                Console.WriteLine("Enter first number");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number number");
                int j = Convert.ToInt32(Console.ReadLine());
                int result;

                switch (choice)
                {

                    case 1:
                        result = i + j;
                        Console.WriteLine("Addition = " + result);
                        break;
                    case 2:
                        result = i - j;
                        Console.WriteLine("Substraction = " + result);
                        break;
                    case 3:
                        result = i * j;
                        Console.WriteLine("Multiplication = " + result);
                        break;
                    case 4:
                        result = i / j;
                        Console.WriteLine("Division = " + result);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice..");
                        break;
                }
            }



            Console.ReadLine();


        }
    }
}
