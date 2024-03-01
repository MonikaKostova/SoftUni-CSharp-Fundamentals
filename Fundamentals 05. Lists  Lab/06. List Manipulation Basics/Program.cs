﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while(input != "end")
            {
                List<string> commands = input
                    .Split()
                    .ToList();

                string command = commands[0];
                switch (command)
                {
                    case "Add":
                        int numberToAdd = int.Parse(commands[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(commands[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(commands[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(commands[1]);
                        int indexToInsert = int.Parse(commands[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
