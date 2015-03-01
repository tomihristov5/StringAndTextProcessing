// Problem 11. Format number
// Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
// Format the output aligned right in 15 symbols.

using System;

namespace _11.FormatNumber
{
    class FormatNumber
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Number in decimal is: {0}", number);
            Console.WriteLine("Number in hexadecimal is: {0:X}", number);
            Console.WriteLine("Number as percentage is: {0:P}", (float)number / 100);
            Console.WriteLine("Number in scientific notation: {0:E}", number);
        }
    }
}
