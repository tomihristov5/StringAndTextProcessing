// Problem 20. Palindromes
// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Text.RegularExpressions;

namespace _20.Palindromes
{
    class Palindromes
    {
        static public string[] ExtractPalindromes(string str)
        {
            string RegexPattern = @"(?<N>.)+.?(?<-N>\k<N>)+(?(N)(?!))";
            MatchCollection matches = Regex.Matches(str, RegexPattern, RegexOptions.IgnoreCase);
            string[] MatchList = new string[matches.Count];
            int c = 0;
            foreach (Match match in matches)
            {
                MatchList[c] = match.ToString();
                c++;
            }
            return MatchList;
        }
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string[] palindromes = ExtractPalindromes(Console.ReadLine());

            foreach (string palindrome in palindromes)
            {
                Console.WriteLine(palindrome);
            }
        }
    }
}
