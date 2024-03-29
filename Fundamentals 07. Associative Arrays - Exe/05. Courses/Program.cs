﻿using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesInfo = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = cmdArgs[0]; 
                string studentName = cmdArgs[1];

                if (!coursesInfo.ContainsKey(courseName))
                {
                    coursesInfo[courseName] = new List<string>();
                }
                coursesInfo[courseName].Add(studentName);
            }
            foreach (var kvp in coursesInfo)
            {
                string courseName = kvp.Key;
                List<string> students = kvp.Value;

                Console.WriteLine($"{courseName}: {students.Count}");

                foreach (string studentName in students)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
