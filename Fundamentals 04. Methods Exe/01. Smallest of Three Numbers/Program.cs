using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int thirdNumber = int.Parse(Console.ReadLine());

                int result = PrintSmallestNumber(firstNumber, secondNumber, thirdNumber);
                Console.WriteLine(result);
            }

            static int PrintSmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
            {
                int smallestNumber = Math.Min(Math.Min(firstNumber, secondNumber), thirdNumber);

                return smallestNumber;
            }
        }
    }
}
