using System;

namespace Задача_
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            int winner = int.MinValue;
            string nameWinner = "";
            int sum = 0;
            while (name != "Stop")
            {
                
                for (int i = 0; i < name.Length; i++)
                {
                    int choose = int.Parse(Console.ReadLine());
                    int a = name[i];
                    if (choose == a)
                    {
                        sum += 10;
                    }
                    else sum += 2;
                   
                }
                if (sum >= winner)
                {
                    winner = sum;
                    nameWinner = name;
                }
                name = Console.ReadLine();
                sum = 0;
            }
            Console.WriteLine($"The winner is {nameWinner} with {winner} points!");
        }
    }
}
