// Problem 2. Reverse string
// Write a program that reads a string, reverses it and prints the result at the console.


using System;

namespace _02.ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
