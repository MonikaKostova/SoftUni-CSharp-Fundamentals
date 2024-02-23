using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());   
            
            decimal fullCourses = Math.Ceiling((decimal)numPeople / capacity);

            Console.WriteLine(fullCourses);
        }
    }
}
