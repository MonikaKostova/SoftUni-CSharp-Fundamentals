using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> occurances = new Dictionary<char, int>();

            string text = Console.ReadLine();

            foreach (char character in text)
            {
                if (character != ' ')
                {
                    if (!occurances.ContainsKey(character))
                    {
                        occurances[character] = 0;
                    }
                    else
                    {
                        occurances[character]++;
                    }
                }
            }

            foreach (var kvp in occurances)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
