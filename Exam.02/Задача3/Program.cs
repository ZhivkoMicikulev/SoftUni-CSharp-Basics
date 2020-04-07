using System;

namespace Задача3
{
    class Program
    {
        static void Main(string[] args)
        {
            string coffee = Console.ReadLine();
            string sugar = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            double sum = 0.0;
            if (coffee== "Espresso")
            {
                if (sugar == "Without")
                {
                    sum += num * 0.9;
                    
                }
               else if (sugar == "Normal") sum += num * 1;
                else if (sugar == "Extra") sum += num * 1.20;
            }
            else if (coffee == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    sum += num * 1;
                    
                }
              
               else  if (sugar == "Normal") sum += num * 1.2;
                else if (sugar == "Extra") sum += num * 1.60;
            }
           else if (coffee == "Tea")
            {
                if (sugar == "Without")
                {
                    sum += num * 0.5;
                   
                }
               else if (sugar == "Normal") sum += num * 0.6;
               else if (sugar == "Extra") sum += num *0.7;
            }

            if (coffee == "Espresso" && num >= 5 && sum < 15 && sugar == "Without")
            {
                sum = sum - (sum * 0.35);
                Console.WriteLine($"You bought {num} cups of {coffee} for {sum - (sum * 0.25):f2} lv.");
            }
          else  if (coffee == "Espresso" && num >= 5 && sum < 15)
            {
                Console.WriteLine($"You bought {num} cups of {coffee} for {sum - (sum * 0.25):f2} lv.");
            }
            else if (coffee == "Espresso" && num >= 5 && sum > 15 && sugar == "Without")
            {
                sum = sum - (sum * 0.35);
                sum = sum - (sum * 0.25);
                sum = sum - (sum * 0.2);
                Console.WriteLine($"You bought {num} cups of {coffee} for {sum:f2} lv.");
            }
            else if (coffee == "Espresso" && num >= 5 && sum > 15 )
            {
                sum = sum - (sum * 0.25);
                sum = sum - (sum * 0.2);
                Console.WriteLine($"You bought {num} cups of {coffee} for {sum:f2} lv.");
            }
            else if (sum > 15 && sugar == "Without")
            {
                sum = sum - (sum * 0.35);
                Console.WriteLine($"You bought {num} cups of {coffee} for {sum - (sum * 0.2):f2} lv.");
            }
            else if (sum > 15) Console.WriteLine($"You bought {num} cups of {coffee} for {sum - (sum * 0.2):f2} lv.");
            else if (sugar == "Without")
            {
                sum = sum - (sum * 0.35);
                Console.WriteLine($"You bought {num} cups of {coffee} for {sum:f2} lv.");
            }
            else Console.WriteLine($"You bought {num} cups of {coffee} for {sum:f2} lv.");
        }
    }
}
