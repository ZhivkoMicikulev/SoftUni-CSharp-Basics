using System;

namespace Задача4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int mag = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = 0;
            int r = 0;
            for (int i = n1; i <= n2; i++)
            {
                for (int j = n1; j <= n2; j++)
                {
                    sum++;
                    if(i+j==mag)
                    {
                        Console.WriteLine($"Combination N:{sum} ({i} + {j} = {mag})");
                        r++;
                        break;
                    }
                    else
                    {
                        sum1++;
                    }
                    
                }
                if (r == 1)
                {
                    break;
                }
            }
            if (sum1 == sum)
            {
                Console.WriteLine($"{sum} combinations - neither equals {mag}");
            }

        }

    }
}
