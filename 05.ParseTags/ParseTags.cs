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
            string input = Console.ReadLine();
            var items = new List<string>();
            foreach (Match match in Regex.Matches(input, "<upcase>(.*?)</upcase>"))
                items.Add(match.Groups[1].Value);
            string output = string.Join("*", items);
            string[] outputs = output.Split('*');
            string replaced = input
                .Replace("<upcase>" + items[0] + "</upcase>", outputs[0].ToUpper())
                .Replace("<upcase>" + items[1] + "</upcase>", outputs[1].ToUpper());
            Console.WriteLine(replaced);
        }
    }
}
