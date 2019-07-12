using System;
using System.Globalization;

namespace DaysInMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program gets the number of days of a given month for a year");

            Console.WriteLine("Enter the month number: ");
            int monthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the year number: ");
            int year = int.Parse(Console.ReadLine());

            DateTimeFormatInfo dateInfo = new DateTimeFormatInfo();
            string monthName = dateInfo.GetMonthName(monthNumber);
            int daysInMonth = DateTime.DaysInMonth(year, monthNumber);

            Console.WriteLine("The number of days in the month {0} is: {1}", monthName, daysInMonth);
            Console.ReadKey();
        }
    }
}
