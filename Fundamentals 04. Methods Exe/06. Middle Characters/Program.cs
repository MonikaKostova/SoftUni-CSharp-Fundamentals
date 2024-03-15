using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintMiddleCharacter(text);
        }

        private static void PrintMiddleCharacter(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.WriteLine($"{text[text.Length / 2 - 1]}{text[text.Length / 2]}");
            }
            else
            {
                Console.WriteLine(text[text.Length / 2]);
            }
        }
    }
    
}
