﻿using System;

namespace _9._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int l = 1;

            for (int i = 1; i <= n; i++, l += 2)
            {
                Console.WriteLine(l);
                sum += l;
            }
            Console.WriteLine($"Sum: {sum}");    
        }
    }
}
