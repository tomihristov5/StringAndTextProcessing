using System;

namespace _06.StringLength
{
    class StringLength
    {
        static void Main()
        {
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
