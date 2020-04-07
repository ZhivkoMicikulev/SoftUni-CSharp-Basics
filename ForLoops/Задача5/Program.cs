using System;

namespace Задача5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
              double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            for (int i=1;i<=n;i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a%4==0)
                {
                    p3++;
                }
                if (a%3==0)
                {
                    p2++;
                }
                if (a%2==0)
                {
                    p1++;
                }

            }
           

            Console.WriteLine($"{(p1 / n * 100):f2}%");
            Console.WriteLine($"{(p2 / n * 100):f2}%");
            Console.WriteLine($"{(p3 / n * 100):f2}%");
        }
    }
}
