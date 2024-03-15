using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            MakingMatrix(number);
        }

        static void MakingMatrix(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= number; col++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}
