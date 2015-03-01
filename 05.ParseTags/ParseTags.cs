// Problem 5. Parse tags
// You are given a text. Write a program that changes the text in all regions surrounded by the tags 
// <upcase> and </upcase> to upper-case.
// The tags cannot be nested.

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05.ParseTags
{
    class ParseTags
    {
        static void Main()
        {
            Console.WriteLine("Enter some text with, parts of it surrounded by the tags <upcase> and </upcase>: ");
            string input = Console.ReadLine();
            var items = new List<string>();
            foreach (Match match in Regex.Matches(input, "<upcase>(.*?)</upcase>"))
                items.Add(match.Groups[1].Value);
            string output = string.Join(" ", items);
            string[] outputs = output.Split('*');
            string replaced = input
                .Replace("<upcase>" + items[0] + "</upcase>", outputs[0].ToUpper())
                .Replace("<upcase>" + items[1] + "</upcase>", outputs[1].ToUpper());
            Console.WriteLine("The text with the repalced upper-case words is: ");
            Console.WriteLine(replaced);
        }
    }
}
