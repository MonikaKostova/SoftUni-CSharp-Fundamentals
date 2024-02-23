using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int daysCount = 0;
            int totalYield = 0;

            if(startingYield < 100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
                return;
            }
            while(startingYield >= 100)
            {
                daysCount++;
                totalYield += startingYield - 26; // workers cosumation
                startingYield -= 10; // yield drop
            }
            totalYield -= 26;

            Console.WriteLine(daysCount);
            Console.WriteLine(totalYield);  
        } 
    }
}
