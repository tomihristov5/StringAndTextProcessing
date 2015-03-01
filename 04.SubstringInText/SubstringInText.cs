// Problem 4. Sub-string in text
// Write a program that finds how many times a sub-string is
// contained in a given text (perform case insensitive search).

using System;
using System.Text;

namespace _04.SubstringInText
{
    class SubstringInText
    {
        static void Main()
        {
            Console.WriteLine("Enter some text:");
            string input = Console.ReadLine();
            Console.Write("Enter the substring you want to search for: ");
            string searchTarget = Console.ReadLine();
            int count = 0;
            int index = input.IndexOf(searchTarget);
            while (index > - 1)
            {
                count++;
                index = input.IndexOf(searchTarget, index + 1);
            }
            Console.WriteLine("The result is: " + count);
        }
    }
}
