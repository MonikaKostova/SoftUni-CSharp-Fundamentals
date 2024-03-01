using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            decimal result = Result(firstNumber, action, secondNumber);
            Console.WriteLine(result);
        }

        static decimal Result(decimal firstNumber, string action, decimal secondNumber)
        {
            decimal result = 0m;
            
            switch (action)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                result = firstNumber / secondNumber;
                    break;
            }

            return result;
        }
    }
}
