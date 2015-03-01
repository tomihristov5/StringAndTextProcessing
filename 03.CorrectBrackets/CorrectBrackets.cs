// Problem 3. Correct brackets
// Write a program to check if in a given
// expression the brackets are put correctly.

using System;

namespace _03.CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            Console.WriteLine("Write an expression : ");
            string expression = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    counter++;
                }
                if (expression[i] == ')')
                {
                    counter--;
                }
            }
            if (counter != 0 || expression[0] == ')' || expression[expression.Length - 1] == '(')
            {
                Console.WriteLine("No, there is something wrong!");              
            }
            else
            {
                Console.WriteLine("The brackets are put correctly!");
            }
        }
    }
}
