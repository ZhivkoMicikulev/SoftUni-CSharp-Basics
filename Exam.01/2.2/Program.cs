using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double havliq = double.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            double chadyr = Math.Round((havliq / 3) * 2,2);
            double djapanki = Math.Round (chadyr * 0.75,2);
            double chanta =Math.Round(((havliq + djapanki) / 3),2);
            double final = (havliq + chadyr + djapanki + chanta) - ((havliq + chadyr + djapanki + chanta) * (procent / 100));
            double resto = budget - final;
            if (budget>final)
            {
                Console.WriteLine($"Annie's sum is {final:f2} lv. She has {resto:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {final:f2} lv. She needs {-resto:f2} lv. more.");
            }
        }
    }
}
