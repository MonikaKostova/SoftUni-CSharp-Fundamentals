using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companiesInfo = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split(" -> ");
                string companyName = cmdArgs[0];
                string employeeId = cmdArgs[1];

                if (!companiesInfo.ContainsKey(companyName))
                {
                    companiesInfo.Add(companyName, new List<string>());
                }

                if (!companiesInfo[companyName].Contains(employeeId))
                {
                    companiesInfo[companyName].Add(employeeId);
                }

                command = Console.ReadLine();
            }


            foreach (var kvp in companiesInfo)
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var employeeId in kvp.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}
