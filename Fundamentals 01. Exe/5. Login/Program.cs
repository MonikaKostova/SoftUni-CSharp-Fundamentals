using System;
using System.Runtime.CompilerServices;

namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            int counter = 0;
            bool isBlocked = false;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            while (isBlocked == false && password != Console.ReadLine())
            {
                counter++;
                if (counter > 3)
                {
                    isBlocked = true;
                    Console.WriteLine($"User {username} blocked!");
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            if (isBlocked == false && (password != Console.ReadLine()))
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
