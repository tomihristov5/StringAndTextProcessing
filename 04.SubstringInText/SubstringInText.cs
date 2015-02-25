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
            Console.WriteLine("Enter the substring you want to search for: ");
            string searchTarget = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (int index = input.IndexOf(searchTarget))
                {
                    count++;
                }            
            }
            Console.WriteLine(count);
        }
    }
}
