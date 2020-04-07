using System;

namespace Задача3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double Oddmax = double.MinValue;
            double Oddmin = double.MaxValue;
            double evenSum = 0;
            double evenmax = double.MinValue;
            double evenmin = double.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += a;
                    if (a > evenmax)
                    {
                        evenmax = a;
                    }
                    if (a < evenmin)
                    {
                        evenmin = a;
                    }
                }
                else
                {
                    oddSum += a;
                    if (a > Oddmax)
                    {
                        Oddmax = a;
                    }
                    if (a < Oddmin)
                    {
                        Oddmin = a;
                    }

                }
            }
          
            Console.WriteLine($"OddSum ={oddSum}:f2");
            Console.WriteLine($"OddMin ={Oddmin}:f2");
            Console.WriteLine($"OddMax ={Oddmax}:f2");
            Console.WriteLine($"EvenSum ={evenSum}:f2");
            Console.WriteLine($"EvenMin ={evenmin}:f2");
            Console.WriteLine($"EvenMax ={evenmax}:f2");


        }
    }
}
