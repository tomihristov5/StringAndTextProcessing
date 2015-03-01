// Problem 18. Extract e-mails
// Write a program for extracting all email addresses from given text.
// All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18.ExtractEmails
{
    class ExtractEmails
    {
        static void Main()
        {
            Console.WriteLine("Enter some text with some e-mail addressed in it: ");
            string text = Console.ReadLine();
            string[] words = text.Split(new string[] { " ", ";", ",", ". " }, StringSplitOptions.RemoveEmptyEntries);
            string regex = @"^([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})" +
                       @"@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})$";
            Console.WriteLine("Extracted e-mail addresses:");
            for (int i = 0; i < words.Length; i++)
            {
                if (Regex.IsMatch(words[i], regex))
                {
                    Console.WriteLine(" - {0}", words[i]);
                }
            }
        }
    }
}
