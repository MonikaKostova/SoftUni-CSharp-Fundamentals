using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
           
            int counter = 0;
            double expenses = 0;
            
            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    expenses += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    expenses += mousePrice;
                }
                if (i % 6 == 0)
                {
                    expenses += keyboardPrice;
                    counter ++;
                }
                if (counter == 2)
                {
                    expenses += displayPrice;
                    counter = 0;
                }
            }
            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
