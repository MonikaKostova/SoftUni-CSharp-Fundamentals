using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            double powerNum = double.Parse(Console.ReadLine());   

            double mathPower = BaseToPower(baseNum, powerNum);
            Console.WriteLine(mathPower);
        }

        static double BaseToPower (double baseNum, double power)
        {
            double result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}
