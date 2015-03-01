// Problem 6. String length
// Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
// Print the result string into the console.

using System;

namespace _06.StringLength
{
    class StringLength
    {
        static void Main()
        {
            Console.WriteLine("Enter a string with a maximum of 20 characters:");
            string input = Console.ReadLine();
            string output = input;
            for (int i = 0; i < 20 - input.Length; i++)
            {
                output = output + "*";
            }
            Console.WriteLine(output);
        }
    }
}
