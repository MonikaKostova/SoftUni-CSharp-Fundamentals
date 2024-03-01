using System;
using System.ComponentModel;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string calculationType = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Calculations(number1, number2, calculationType);
        }

        static void Calculations(double number1, double number2, string calculationType)
        {
            switch (calculationType)
            {
                case "add":
                    Console.WriteLine(number1 + number2);
                    break;
                case "substract":
                    Console.WriteLine(number1 - number2);
                    break;
                case "multiply":
                    Console.WriteLine(number1 * number2);
                    break;
                case "divide":
                    Console.WriteLine(number1 / number2);
                    break;
            }
        }
    }
}
