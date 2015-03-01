// Problem 17. Date in Bulgarian
// Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.


using System;
using System.Globalization;

namespace _17.DateInBulgarian
{
    class DateInBulgarian
    {
        static void Main()
        {
            Console.Write("Enter date (d.M.yyyy H:mm:ss): ");
            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "d.M.yyyy H:mm:ss", CultureInfo.InvariantCulture);
            date = date.AddHours(6);
            date = date.AddMinutes(30);
            Console.WriteLine("Date after 6 hours and 30 mins and day of week: \n {0}", 
                date.ToString("dddd dd.MM.yyyy HH:mm:ss", new CultureInfo("bg-BG")));
        }
    }
}
