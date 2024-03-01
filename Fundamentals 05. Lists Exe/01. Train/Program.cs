using System;
using System.Collections.Generic;
using System.Linq;


namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> passengersNum = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "end")
            {
                List<string> commands = input
                    .Split()
                    .ToList();

                if (commands[0] == "Add")
                {
                    int numberToAdd = int.Parse(commands[1]);
                    passengersNum.Add(numberToAdd);
                }
                else
                {
                    FittingWagon(passengersNum, wagonCapacity, commands);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", passengersNum));
        }

        private static void FittingWagon(List<int> passengersNum, int wagonCapacity, List<string> commands)
        {
            int numberToAdd = int.Parse(commands[0]);

            for (int i = 0; i < passengersNum.Count; i++)
            {
                if (passengersNum[i] + numberToAdd <= wagonCapacity)
                {
                    passengersNum[i] += numberToAdd;
                    break;
                }
            }
        }
    }
}
