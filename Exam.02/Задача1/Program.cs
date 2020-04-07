using System;

namespace Задача1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double shezlongPrice = double.Parse(Console.ReadLine());
            double umbrelaPrice = double.Parse(Console.ReadLine());
            double sumPrice = num * price;
            double finNum = num / 2;
            double a = Math.Ceiling(finNum);
             double umbrelaNeed =(a) * umbrelaPrice;
            double b = num * 0.75;
            double c = Math.Ceiling(b);
            double shezlongNeed = (b) * shezlongPrice;
            double final =(umbrelaNeed + shezlongNeed + sumPrice);
            Console.WriteLine($"{final:f2} lv.");
        }
    }
}
