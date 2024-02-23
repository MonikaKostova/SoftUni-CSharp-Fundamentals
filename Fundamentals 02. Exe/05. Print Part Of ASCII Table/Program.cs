using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstCharacter = int.Parse(Console.ReadLine());
            int lastCharacter = int.Parse(Console.ReadLine());

            for (char i = (char)firstCharacter; i <= (char)lastCharacter; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
