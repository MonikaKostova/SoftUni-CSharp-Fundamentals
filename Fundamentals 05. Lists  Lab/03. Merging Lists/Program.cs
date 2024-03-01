using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ListNum1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> ListNum2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            int minCount = Math.Min(ListNum1.Count, ListNum2.Count);

            for (int i = 0; i < minCount; i++)
            {
                result.Add(ListNum1[i]);
                result.Add(ListNum2[i]);
            }

            if (minCount == ListNum1.Count)
            {
                for (int i = minCount; i < ListNum2.Count; i++)
                {
                    result.Add(ListNum2[i]);
                }
            }
            else
            {
                for (int i = minCount; i < ListNum1.Count; i++)
                {
                    result.Add(ListNum1[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
