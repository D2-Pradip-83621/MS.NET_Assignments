using System;

namespace Question6

{
    internal class Program
    {


        public class Date
        {
            private int _Day;
            private int _Month;
            private int _Year;

            public Date()
            {
                _Day = 1;
                _Month = 1;
                _Year = 1000;
            }

            public Date(int day, int month, int year)
            {
                this._Day = day;
                this._Month = month;
                this._Year = year;
            }

            public int Day
            {
                get { return _Day; }
                set { _Day = value; }
            }

            public int Month
            {
                get { return _Month; }
                set { _Month = value; }
            }

            public int Year
            {
                get { return _Year; }
                set { _Year = value; }
            }

            public void AcceptDate()
            {
                Console.Write("Enter day: ");
                Day = int.Parse(Console.ReadLine());
                Console.Write("Enter month: ");
                Month = int.Parse(Console.ReadLine());
                Console.Write("Enter year: ");
                Year = int.Parse(Console.ReadLine());
            }

            public void PrintDate()
            {
                Console.WriteLine(ToString());
            }

            public bool IsValid()
            {
                if (_Year < 1) return false;
                if (_Month < 1 || _Month > 12) return false;

                int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                if (IsLeapYear(_Year))
                {
                    daysInMonth[1] = 29; 
                }

                if (_Day < 1 || _Day > daysInMonth[_Month - 1]) return false;

                return true;
            }

            public override string ToString()
            {
                return $"{_Day:D2}/{_Month:D2}/{_Year:D4}";
            }

            public static int CalculateYearDifference(Date date1, Date date2)
            {
                return Math.Abs(date1._Year - date2._Year);
            }

            public static int operator -(Date date1, Date date2)
            {
                return CalculateYearDifference(date1, date2);
            }

            private bool IsLeapYear(int year)
            {
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0) return true;
                        else return false;
                    }
                    else return true;
                }
                else return false;
            }

            static void Main(string[] args)
            {
                Date date1 = new Date();
                Date date2 = new Date();

                Console.WriteLine("Enter first date:");
                date1.AcceptDate();
                Console.WriteLine("Enter second date:");
                date2.AcceptDate();

                if (!date1.IsValid() || !date2.IsValid())
                {
                    Console.WriteLine("One of the dates is invalid.");
                    return;
                }

                Console.WriteLine("First date:");
                date1.PrintDate();
                Console.WriteLine("Second date:");
                date2.PrintDate();

                int yearDifference = date1 - date2;
                Console.WriteLine($"Difference in years: {yearDifference}");
            }
        }
    }

    

}

