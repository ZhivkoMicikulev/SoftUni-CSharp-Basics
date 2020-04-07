using System;

namespace Задача2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double nightPrice = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            
            double finalSum = 0.0;
            if (nights>7)
            {
                double razhodi = budget * (percent / 100);
                double discPrice = nightPrice - (nightPrice * 0.05);
                finalSum += discPrice * nights;
                finalSum += razhodi;
            }
            else
            {
                double razhodi = budget * (percent / 100);
                finalSum += nightPrice * nights;
                finalSum += razhodi;
            }
            if(finalSum<=budget)
            {
                Console.WriteLine($"Ivanovi will be left with {budget-finalSum:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{finalSum-budget:f2} leva needed.");
            }
        }
    }
}
