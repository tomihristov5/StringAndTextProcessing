using System;

namespace _13.ReverseSentence
{
    class ReverseSentence
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
