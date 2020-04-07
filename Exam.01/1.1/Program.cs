using System;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double kg = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());
            double sok = kg * 980;
            double kolichestvo = sok + water * 1000 + (sugar * 0.3);
            double chashi =Math.Floor (kolichestvo / 150);
            double pari = chashi * 1.2;
            Console.WriteLine($"All cups sold: {chashi}");
            Console.WriteLine($"Money earned: {pari:f2}");
        }
    }
}
