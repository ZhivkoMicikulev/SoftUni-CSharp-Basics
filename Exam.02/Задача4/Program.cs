using System;

namespace Задача4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double finalSum= 0.0;
            double midsum = 0.0;
            while (name!="Party!")
            {
                int number = int.Parse(Console.ReadLine());
                int price = name.Length;
                midsum += price * number;
                if (midsum % 2 != 0)
                {

                    finalSum += midsum - (midsum * 0.25);
                }
                else finalSum += midsum;
                if(finalSum>=sum)
                {
                    break;
                }
                midsum = 0;
                name = Console.ReadLine();
            }
            if(name=="Party!")
            {
                Console.WriteLine($"We need {sum - finalSum:f2} leva more.");
                Console.WriteLine($"Club income - {finalSum:f2} leva.");
            }
            else if (finalSum >= sum)
            {
                Console.WriteLine("Target acquired.");
                Console.WriteLine($"Club income - {finalSum:f2} leva.");
            }
        }
    }
}
