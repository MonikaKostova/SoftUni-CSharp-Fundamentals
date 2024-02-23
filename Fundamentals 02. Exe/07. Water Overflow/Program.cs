using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            
            int filledCapacity = 0;

            for (int i = 1; i <= numberOfLines; i++)
            {
                int waterLiters = int.Parse(Console.ReadLine());
                
                if (filledCapacity + waterLiters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    filledCapacity = filledCapacity + waterLiters;

                }
            }
            Console.WriteLine(filledCapacity);
        }
    }
}
