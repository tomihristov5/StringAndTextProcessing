﻿// Problem 8. Extract sentences
// Write a program that extracts from a given text all sentences containing given word.

using System;

namespace _08.ExtractSentences
{
    class ExtractSentences
    {
        static void Main()
        {
            Console.WriteLine("Enter some text: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the word: ");
            string word = Console.ReadLine();
            char[] separator = {'.'};
            string[] inputAsSentences = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < inputAsSentences.Length; i++)
            {
                int index = inputAsSentences[i].IndexOf(word + " ");
                if (index >= 0)
                {
                    Console.Write("{0}.", inputAsSentences[i]);
                }
                else
                    continue;
            }
            Console.WriteLine();
        }
    }
}
