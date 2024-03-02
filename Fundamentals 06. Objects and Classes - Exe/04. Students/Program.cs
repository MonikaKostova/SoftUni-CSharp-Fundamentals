using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = cmdArg[0];
                string lastName = cmdArg[1];
                double grade = double.Parse(cmdArg[2]);

                Student currentStudent = new Student(firstName, lastName, grade);
                students.Add(currentStudent);
            }

            List<Student> orderedStudent = students
                .OrderByDescending(s => s.Grade)
                .ToList();

            foreach(Student student in orderedStudent)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
    
    public class Student
    {
        public Student (string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
    
        public string FirstName { get; private set; }

        public string LastName { get; private set;}

        public double Grade { get; set; }
    }
}
