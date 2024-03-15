using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string resource;
            while ((resource =  Console.ReadLine()) != "stop")
            {
                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }
                int quantity = int.Parse(Console.ReadLine());
                resources[resource] += quantity;
            }

            foreach (var kvp in resources) // key value pairs
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
