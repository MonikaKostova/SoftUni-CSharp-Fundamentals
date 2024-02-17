using System;
using System.Collections.Generic;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int ordersNum = int.Parse(Console.ReadLine());
             decimal price = 0;
             decimal totalPrice = 0; 

            for (int i = 0; i < ordersNum; i++)
            {
              
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());   
                int capsulesCount = int.Parse(Console.ReadLine()); 

                price = (days * capsulesCount) * pricePerCapsule;
                totalPrice += price;
                
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
            }
                       
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
