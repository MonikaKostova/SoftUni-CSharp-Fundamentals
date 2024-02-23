using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // poke power 
            int m = int.Parse(Console.ReadLine()); // distance between targets
            int y = int.Parse(Console.ReadLine()); // exhaustion factor

            int pokeCount = 0;
            int originalN = n;

            while (n >= m)
            {
                n = n - m;
                pokeCount++;
                if (originalN / 2 == n && y != 0)
                {
                    n = n / y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(pokeCount);
        }
    }
}
