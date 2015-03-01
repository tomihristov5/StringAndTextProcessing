// Problem 24. Order words
// Write a program that reads a list of words,
// separated by spaces and prints the list in an alphabetical order.

using System;

namespace _24.OrderWords
{
    class OrderWords
    {
        static void Main()
        {
            Console.WriteLine("Enter words, separated by spaces: ");
            string[] words = Console.ReadLine().Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            Console.WriteLine(string.Join("\n", words));
        }
    }
}
