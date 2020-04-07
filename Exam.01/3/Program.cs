using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int wCase = int.Parse(Console.ReadLine());
            int hCase = int.Parse(Console.ReadLine());
            int dCase = int.Parse(Console.ReadLine());
            bool ticket = bool.Parse(Console.ReadLine());
            int obem = wCase * hCase * dCase;
           if (obem<50)
            {
                Console.WriteLine("Luggage tax: 0.00");
            }
            switch (ticket)
            {   
                case false:
                    if (obem > 50 && obem <= 100)
                    {
                        Console.WriteLine("Luggage tax: 25.00");
                    }
                    else if (obem > 100 && obem <= 200)
                    {
                        Console.WriteLine("Luggage tax: 50.00");
                    }
                    else if (obem > 200 && obem <= 300)
                    {
                        Console.WriteLine("Luggage tax: 100.00");
                    }
                    break;
                case true:
                    if (obem > 50 && obem <= 100)
                    {
                        Console.WriteLine("Luggage tax: 0.00");
                    }

                    else if (obem > 100 && obem <= 200)
                    {
                        Console.WriteLine("Luggage tax: 10.00");
                    }

                    else if (obem > 200 && obem <= 300)
                    {
                        Console.WriteLine("Luggage tax: 20.00");
                    }
                    break;

             
            
            }
        }
    }
}
