using System;
using System.Runtime.Serialization.Formatters;

namespace _4._Print_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = firstNum; i <= lastNum; i++)
            {
                sum = sum + i;

                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
