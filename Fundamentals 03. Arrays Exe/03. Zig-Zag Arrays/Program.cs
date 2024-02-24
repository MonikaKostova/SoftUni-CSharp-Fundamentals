using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstNums = new int[n];
            int[] secondNums = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray(); 

                if (i % 2 == 0)
                {
                    firstNums[i] = nums[0];
                    secondNums[i] = nums[1];    
                }
                else
                {
                    firstNums[i] = nums[1]; 
                    secondNums[i] = nums[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstNums));
            Console.WriteLine(string.Join(" ", secondNums));

        }
    }
}
