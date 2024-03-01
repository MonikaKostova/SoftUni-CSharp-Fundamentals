using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> bombNumber = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbersList = Explode(numbersList, bombNumber);

            Console.WriteLine(Sum(numbersList));
        }

        private static int Sum(List<int> numbersList)
        {
            int sum = 0;
            foreach (int item in numbersList)
            {
                sum += item;
            }

            return sum;
        }

        private static List<int> Explode(List<int> numbersList, List<int> bombNumber)
        {
            int number = bombNumber[0];
            int power = bombNumber[1];

            while (numbersList.Contains(number))
            {
                int index = numbersList.IndexOf(number);

                int leftIndex = Math.Max(0, index - power);
                int rightIndex = Math.Min(numbersList.Count - 1, index + power);

                int range = rightIndex - leftIndex + 1;
                numbersList.RemoveRange(leftIndex, range);
            }

            return numbersList;
        }
    }
}
