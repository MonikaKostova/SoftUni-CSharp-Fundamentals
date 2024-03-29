﻿using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTopNumbers(number);
        }

        private static void PrintTopNumbers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;

                int currentNumber = i;
                int numberToDivide = currentNumber;

                int counterOfOddDigits = 0;

                while (numberToDivide != 0)
                {
                    currentNumber = numberToDivide % 10;
                    numberToDivide /= 10;

                    if (currentNumber % 2 != 0)
                    {
                        counterOfOddDigits++;
                    }

                    sum += currentNumber;
                }

                if (sum % 8 == 0 && counterOfOddDigits >= 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
