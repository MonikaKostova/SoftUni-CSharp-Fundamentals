using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            long finalResult = Factorial(firstNumber) / Factorial(secondNumber);
            Console.WriteLine($"{finalResult:f2}");
        }

        static long Factorial(long number)
        {
            long factorial = number;

            for (long i = number - 1; i >= 1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
