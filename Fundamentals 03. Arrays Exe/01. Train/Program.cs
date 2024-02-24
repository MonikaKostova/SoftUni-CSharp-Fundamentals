using System;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsNum = int.Parse(Console.ReadLine());
            int[] wagons = new int[wagonsNum];

            for (int i = 0; i < wagons.Length; i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                wagons[i] = passengers;
            }
            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(wagons.Sum());
        }
       
    }
}
