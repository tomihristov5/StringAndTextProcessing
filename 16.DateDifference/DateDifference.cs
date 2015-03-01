using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int days = firstDate.Day - secondDate.Day;
            if (firstDate.Day > secondDate.Day)
            {
                Console.WriteLine(DateTime.DaysInMonth(firstDate.Year, firstDate.Month) - days);
            }
            else
                Console.WriteLine(days);
        }
    }
}
