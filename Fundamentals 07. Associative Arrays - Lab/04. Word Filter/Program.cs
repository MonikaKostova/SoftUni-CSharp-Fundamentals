using System;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(" ")
                .Where(w => w.Length % 2 == 0)
                .ToList();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
