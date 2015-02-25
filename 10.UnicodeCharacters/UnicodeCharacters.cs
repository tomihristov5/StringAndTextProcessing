using System;

namespace _10.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            foreach (char ch in input)
            {
                Console.Write("\\u" + ((int)ch).ToString("X4"));
            }
            Console.WriteLine();
        }
    }
}
