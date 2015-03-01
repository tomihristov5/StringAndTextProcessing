// Problem 13. Reverse sentence
// Write a program that reverses the words in given sentence.

using System;

namespace _13.ReverseSentence
{
    class ReverseSentence
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            Console.WriteLine("Reversed sentence is: ");
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
