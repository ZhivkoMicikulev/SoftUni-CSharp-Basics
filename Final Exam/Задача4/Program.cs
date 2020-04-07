using System;

namespace Задача4
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            var real = 0.0;
            int item = 0;
            int counItem = 1;
            var last = 0.0;
            while (name != "Finish" || budget <= 0)
            {
                if (name == "Star")
                {
                    if (counItem == 3)
                    {
                        real += 5.69 - (5.69 * 0.3);
                        last = 5.69 - (5.69 * 0.3);
                        budget -= 5.69 - (5.69 * 0.3);
                        item++;
                        counItem = 0;
                    }
                    else
                    {
                        real += 5.69;
                        last = 5.69;
                        budget -= 5.69;
                        item++;
                    }
                    if (budget<=0)
                    {
                        item--;
                       
                        break;
                    }
                }
              else  if (name == "Angel")
                {
                    if (counItem == 3)
                    {
                        real += 8.49 - (8.49 * 0.3);
                        last = 8.49 - (8.49 * 0.3);
                        budget -= 8.49 - (8.49 * 0.3);
                        item++;
                        counItem = 0;
                    }
                    else
                    {
                        real += 8.49;
                        last = 8.49;
                        budget -= 8.49;
                        item++;
                    }
                    if (budget <= 0)
                    {
                        item--;
                        break;
                    }
                }
              else  if (name == "Lights")
                {
                    if (counItem == 3)
                    {
                        real += 11.20 - (11.20 * 0.3);
                        last = 11.20 - (11.20 * 0.3);
                        budget -= 11.20 - (11.20 * 0.3);
                        item++;
                        counItem = 0;
                    }
                    else
                    {
                        real += 11.20;
                        last = 11.20;
                        budget -= 11.20;
                        item++;
                    }
                    if (budget <= 0)
                    {
                        item--;
                        break;
                    }
                }
              else  if (name == "Wreath")
                {
                    if (counItem  == 3)
                    {
                        real += 15.50 - (15.50 * 0.3);
                        last = 15.50 - (15.50 * 0.3);
                        budget -= 15.50 - (15.50 * 0.3);
                        item++;
                        counItem = 0;
                    }
                    else
                    {
                        real += 15.50;
                        last = 15.50;
                        budget -= 15.50;
                        item++;
                    }
                    if (budget <= 0)
                    {
                        item--;
                        break;
                    }
                }
            
                else    if (name == "Candle")
                {
                    if (counItem  == 3)
                    {
                        real += 3.59 - (3.59 * 0.3);
                        last = 3.59 - (3.59 * 0.3);
                        budget -= 3.59 - (3.59 * 0.3);
                        item++;
                        counItem = 0;
                    }
                    else
                    {
                        real += 3.59;
                        last = 3.59;
                        budget -= 3.59;
                        item++;
                    }
                    if (budget <= 0)
                    {
                        item--;
                        break;
                    }

                }
                name = Console.ReadLine();
                if (name == "Finsih") item--;
                counItem++;
               
            }
             if(name=="Finish")
            {
                Console.WriteLine("Congratulations! You bought everything!");
                Console.WriteLine($"{item} items -> {real:f2}lv spent.");
            }
             if(budget<=0)
            {
                Console.WriteLine($"Not enough money! You need {-budget:f2}lv more.");
                Console.WriteLine($"{item} items -> {real-last:f2}lv spent.");
            }
        }
    }
}
