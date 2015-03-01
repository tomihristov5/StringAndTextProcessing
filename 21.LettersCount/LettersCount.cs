// Problem 21. Letters count
// Write a program that reads a string from the console and prints all different letters in the string along with 
// information how manytimes each letter is found.

using System;
using System.Text;

namespace _21.LettersCount
{
    class LettersCount
    {
        static void Main()
        {
            int size = 26;
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = 0;
            }
            text = text.ToLower();
            foreach (char ch in text)
            {
                if (Char.IsLetter(ch))
                {
                    arr[ch - 'a']++;
                }
            }
            for (int i = 0; i < size; i++)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine("Letter '{0}' -> {1} time(s)", (char)(i + 'a'), arr[i]);
                }
            }
        }
    }
}
