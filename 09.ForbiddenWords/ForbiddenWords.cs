using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string forbWords = Console.ReadLine();
            string[] words = forbWords.Split(' ');
            string[] inputAsWords = input.Split(' ');
            string[] replaced = null;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < inputAsWords.Length; j++)
                {
                    if (inputAsWords[j] == words[i])
                    {
                        inputAsWords[j] = replaced[j];
                    }
                }
            }
            for (int i = 0; i < replaced.Length; i++)
            {
                Console.WriteLine(replaced[i]);
            }
        }
    }
}
