// Problem 16. Date difference
// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;

namespace _16.DateDifference
{
    class DateDifference
    {
        static void Main()
        {
            Console.WriteLine("Enter first date in format day.month.year: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter second date in format day.month.year: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            TimeSpan result = firstDate - secondDate;
            Console.WriteLine("The difference is {0} days", (Math.Abs(result.TotalDays)));
        }
    }
}
