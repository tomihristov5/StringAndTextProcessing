// Problem 9. Forbidden words
// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.

using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _09.ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter forbiden words: ");
            string forbWords = Console.ReadLine();
            string[] words = forbWords
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            Console.WriteLine("The output text with replaced words: ");
            Console.WriteLine(Censore(input, words));
        }
        private static string Censore(string text, string[] words)
        {
            return Regex.Replace(text, String.Join("|", words), delegate(Match match)
            {
                string current = match.ToString();
                return Regex.Replace(current, current, new String('*', current.Length));              
            }, RegexOptions.IgnoreCase);
        }
    }
}
