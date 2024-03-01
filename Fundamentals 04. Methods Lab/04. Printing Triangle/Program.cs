using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }
        static void PrintTriangle(int number)
        {
            PrintTopTriangle(number);
            PrintBottomTriangle(number - 1);
        }
        static void PrintTopTriangle (int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintTriangleRow(row);
            }
        }
        static void PrintBottomTriangle (int n) 
        {
            for (int row = n; row >= 1 ; row--)
            {
                PrintTriangleRow(row);
            }
        }
        static void PrintTriangleRow (int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }

    }
}
