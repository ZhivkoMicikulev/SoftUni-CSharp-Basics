using System;

namespace Задача2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double skiPrice = double.Parse(Console.ReadLine());
            double shtekiPrice = double.Parse(Console.ReadLine());
            double bootsPrice = skiPrice - (skiPrice * 0.6);
            double clothesPrice = skiPrice + (skiPrice * 0.4);
            double sum = skiPrice + shtekiPrice + bootsPrice + clothesPrice;
            if (sum-shtekiPrice > 800)
            {
                sum -= shtekiPrice;
               
            }
            if (sum <= budget)
            {
                Console.WriteLine($"Angel's sum is {sum:f2} lv. He has {budget - sum:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {sum-budget:f2} leva more!");
            }

        }
    }
}
