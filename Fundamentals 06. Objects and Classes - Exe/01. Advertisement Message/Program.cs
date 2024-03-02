using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int messagesToGenerate = int.Parse(Console.ReadLine());

            List<string> phrasesList = new List<string>
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
            };

            List<string> eventsList = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            List<string> authorsList = new List<string>
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            List<string> citiesList = new List<string>
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            Random random = new Random();
          
            for (int i = 0; i < messagesToGenerate; i++)
            {
                int randomIndexPhrases = random.Next(messagesToGenerate);
                int randomIndexEvents = random.Next(messagesToGenerate);
                int randomIndexAuthors = random.Next(messagesToGenerate);
                int randomIndexCities = random.Next(messagesToGenerate);

                Console.WriteLine($"{phrasesList[randomIndexPhrases]} {eventsList[randomIndexEvents]} {authorsList[randomIndexAuthors]} - {citiesList[randomIndexCities]}");
            }
        }
    }
}
