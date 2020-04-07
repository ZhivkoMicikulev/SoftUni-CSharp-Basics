using System;

namespace Задача2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            for (int i=1; i<=n;i++)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;
                if (a>max)
                {
                    max = a;
                }

            }
            if (max==(sum-max))
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = Math.Abs(max - (sum - max));
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
