using System;

namespace _3._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleNum = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();  
            string stayDay = Console.ReadLine();

            double totalMoney = 0;

            switch (groupType)
            {
                case "Students":
                    switch (stayDay)
                    {
                        case "Friday":
                            totalMoney = peopleNum * 8.45;
                            break;
                        case "Saturday":
                            totalMoney = peopleNum * 9.80;
                            break;
                        case "Sunday":
                            totalMoney = peopleNum * 10.46;
                            break;
                    }
                    if (peopleNum >= 30)
                    {
                        totalMoney = totalMoney * 0.85;
                    }
                    break;
                case "Business":
                    if (peopleNum < 100)
                    {
                        switch (stayDay)
                        {
                            case "Friday":
                                totalMoney = peopleNum * 10.90;
                                break;
                            case "Saturday":
                                totalMoney = peopleNum * 15.60;
                                break;
                            case "Sunday":
                                totalMoney = peopleNum * 16;
                                break;
                        }
                    }
                    else if (peopleNum >= 100)
                    {
                        switch (stayDay)
                        {
                            case "Friday":
                                totalMoney = (peopleNum - 10) * 10.90;
                                break;
                            case "Saturday":
                                totalMoney = (peopleNum - 10) * 15.60;
                                break;
                            case "Sunday":
                                totalMoney = (peopleNum - 10) * 16;
                                break;
                        }
                    }
                    break;
                case "Regular":
                    switch (stayDay)
                    {
                        case "Friday":
                            totalMoney = peopleNum * 15;
                            break;
                        case "Saturday":
                            totalMoney = peopleNum * 20;
                            break;
                        case "Sunday":
                            totalMoney = peopleNum * 22.50;
                            break;
                    }
                    if (peopleNum >= 10 && peopleNum <=20)
                    {
                        totalMoney = totalMoney * 0.95;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {totalMoney:F2}");
        }
    }
}
