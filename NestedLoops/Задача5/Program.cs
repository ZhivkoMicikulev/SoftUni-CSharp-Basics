using System;

namespace Задача5
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
           int sum = 0;
            while (n != "End")
            {
                sum += int.Parse(n);

                if (a > sum)
                {
                   
                    if (n == "End")
                    {
                        break;
                    }
                    if (a<=sum)
                    {
                        Console.WriteLine($"Going to {n}");
                    }
                }
                sum += int.Parse(n);
            }
        }
    }
}
