using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();   
            int repeats = int.Parse(Console.ReadLine());

            string repeatedText = PrintRepeatedText(text, repeats);
            Console.WriteLine(repeatedText);
        }
        static string PrintRepeatedText(string text, int repeats)
        {
            string result = "";
            for (int i = 1; i <= repeats; i++)
            {
                result += text;
            }
            return result;
        }
    }
}
