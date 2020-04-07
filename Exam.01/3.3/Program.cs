using System;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string where = Console.ReadLine();
            string cabin = Console.ReadLine();
            int bnight = int.Parse(Console.ReadLine());
            int nights = 4 * bnight;
            double rez =Math.Round(0.0 ,2);
            if (where== "Mediterranean")
            {
                if (cabin == "standard cabin")
                {
                    if (bnight < 7) rez = 27.50 * nights;
                    else rez = (nights * 27.50) - ((nights * 27.50) * 0.25);
                }
                else if (cabin == "cabin with balcony")
                {
                    if (bnight < 7) rez = (nights * 30.20);
                    else rez = (nights * 30.20) - ((nights * 30.20) * 0.25);
                }
                else if (cabin == "apartment")
                {
                    if (bnight < 7) rez = (nights * 40.50);
                    else rez = (nights * 40.50) - ((nights * 40.50) * 40.50);
                }
            }
            if (where == "Adriatic")
            {
                if (cabin == "standard cabin")
                {
                    if (bnight < 7) rez = (nights * 22.99);
                    else rez = (nights * 22.99) - ((nights * 22.99) * 0.25);
                }
                else if (cabin == "cabin with balcony")
                {
                    if (bnight < 7) rez = (nights * 25.00);
                    else rez = (nights * 25.00) - ((nights * 25.00) * 0.25);
                }
                else if (cabin == "apartment")
                {
                    if (bnight < 7) rez = (nights * 34.99);
                    else rez = (nights * 34.99) - ((nights * 34.99) * 0.25);
                }
            }
            if (where == "Aegean")
            {
                if (cabin == "standard cabin")
                {
                    if (bnight < 7) rez = (nights * 23.00);
                    else rez = (nights * 23.00) - ((nights * 23.00) * 0.25);
                }
                else if (cabin == "cabin with balcony")
                {
                    if (bnight < 7) rez = (nights * 26.60);
                    else rez = (nights * 26.60) - ((nights * 26.60) * 0.25);
                }
                else if (cabin == "apartment")
                {
                    if (bnight < 7) rez = (nights * 39.80);
                    else rez = (nights * 39.80) - ((nights * 39.80) * 0.25);
                }
            }
            Console.WriteLine($"Annie's holiday in the {where} sea costs {rez:f2} lv.");




        }
    }
}
