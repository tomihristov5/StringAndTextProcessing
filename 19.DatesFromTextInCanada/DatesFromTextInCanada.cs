// Problem 19. Dates from text in Canada
// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
// Display them in the standard date format for Canada

using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

namespace _19.DatesFromTextInCanada
{
    class DatesFromTextInCanada
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-CA");
            string text = Console.ReadLine();
            string[] words = text.Split(new string[] { " ", ";", ",", ". " }, StringSplitOptions.RemoveEmptyEntries);
            string format = "d.M.yyyy";
            CultureInfo newDateFormat = Thread.CurrentThread.CurrentCulture;
            string regex = @"[\d]{1,2}.[\d]{1,2}.[\d]{4}";
            Console.WriteLine("Extracted dates from the sample text:\n");
            for (int i = 0; i < words.Length; i++)
            {
                if (Regex.IsMatch(words[i], regex))
                {
                    try
                    {
                        DateTime isCheck = DateTime.ParseExact(words[i].ToString(), format, newDateFormat);
                        Console.WriteLine("Found date: {0}", isCheck.ToShortDateString());
                    }
                    catch (FormatException)
                    {
                        continue;
                    }
                }
            }

        }
    }
}
