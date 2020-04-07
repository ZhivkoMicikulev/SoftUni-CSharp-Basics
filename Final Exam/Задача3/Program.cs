using System;

namespace Задача3
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string documentType = Console.ReadLine();
            string desert = Console.ReadLine();
            var mounths = int.Parse(Console.ReadLine());
            var sum = 0.0;
            if (type == "one")
            {
                switch (documentType)
                {
                    case "Small":
                        sum += 9.98;
                        break;
                    case "Middle":
                        sum += 18.99;
                        break;
                    case "Large":
                        sum += 25.98;
                        break;
                    case "ExtraLarge":
                        sum += 35.99;
                        break;
                }
                if (desert == "yes")
                {
                    if (sum <= 10) sum += 5.50;
                   else if (sum <= 30) sum += 4.35;
                   else if (sum > 300) sum += 3.85;
                }
                sum = sum * mounths;
            }
            else if (type == "two")
            {
                switch (documentType)
                {
                    case "Small":
                        sum += 8.58;
                        break;
                    case "Middle":
                        sum += 17.09;
                        break;
                    case "Large":
                        sum += 23.59;
                        break;
                    case "ExtraLarge":
                        sum += 31.79;
                        break;
                }
                if (desert == "yes")
                {
                    if (sum <= 10) sum += 5.50;
                    else if (sum <= 30) sum += 4.35;
                    else if (sum > 30) sum += 3.85;
                }
                sum = sum * mounths;
                sum = sum - (sum *(3.75/100));

                
            }
            
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
