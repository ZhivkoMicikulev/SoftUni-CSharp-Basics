using System;

namespace Задача1
{
    class Program
    {
        static void Main(string[] args)
        {
            int mounth = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            double pricePerMounth = double.Parse(Console.ReadLine());
            double discPeriod = mounth / 2;
            double firstPeriod = pricePerMounth * discPeriod;
            double discPeriod2 = mounth - discPeriod;
            double secondPeriod = (pricePerMounth - (pricePerMounth * 0.2)) * discPeriod2;
            double sumForRent = firstPeriod + secondPeriod;
            double sumForBroker = sumForRent * ((double)percent / 100);
            double finalSum = sumForBroker + sumForRent;
            Console.WriteLine($"Total: {finalSum:f2}");

        }
    }
}
