using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = SumOfFirstAndSecondNumber(firstNumber, secondNumber);
            int subtract = SubtractThirdNumberFromSum(thirdNumber, sum);

            Console.WriteLine(subtract);
        }
        static int SubtractThirdNumberFromSum(int thirdNumber, int sum)
        {
            int result = sum - thirdNumber;
            return result;
        }
        static int SumOfFirstAndSecondNumber(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
    }
}
