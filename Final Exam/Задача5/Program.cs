using System;

namespace Задача5
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double dogFood = 0.0;
            double catFood = 0.0;
            double bisc = 0.0;
             int day1 = 0;
            double eatenFood = 0.0;
            for(int i=1;i<=days;i++)
            {
                day1++;
                double dog = double.Parse(Console.ReadLine());
                dogFood += dog;
                eatenFood += dog;
                double cat = double.Parse(Console.ReadLine());
                catFood += cat;
                eatenFood += cat;
                if (day1 == 3)
                {
                    bisc += (cat + dog) * 0.1;
                    day1 = 0;
                }
            }
            double fbisc = Math.Round(bisc);
            Console.WriteLine($"Total eaten biscuits: {fbisc}gr.");
            Console.WriteLine($"{((dogFood + catFood) / food) * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{(dogFood / eatenFood) * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{(catFood / eatenFood) * 100:f2}% eaten from the cat.");
        }
    }
}
