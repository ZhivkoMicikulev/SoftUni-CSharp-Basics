using System;

namespace Задача4
{
    class Program
    {
        static void Main(string[] args)
        {
            


                int n = int.Parse(Console.ReadLine());
                double p1 = 0;
                double p2 = 0;
                double p3 = 0;
                double p4 = 0;
                double p5= 0;
               
                     for (int i = 1; i <= n; i++)
                {
                    int a = int.Parse(Console.ReadLine());
                if (a<200)
                    {
                        p1++;
                    }
                    else if (a>=200&&a<=399)
                    {
                        p2++;
                    } 
                    else if (a>=400&&a<=599)
                    {
                        p3++;
                    } 
                    else if (a>=600&&a<=799)
                    {
                        p4++;
                    }
                    else if (a>=800)
                    {
                        p5++;
                    }
                   

                }


                Console.WriteLine($"{(p1 / n * 100):f2}%");
                Console.WriteLine($"{(p2 / n * 100):f2}%");
                Console.WriteLine($"{(p3 / n * 100):f2}%");
                Console.WriteLine($"{(p4 / n * 100):f2}%");
                Console.WriteLine($"{(p5 / n * 100):f2}%");
            }
        }
    }


