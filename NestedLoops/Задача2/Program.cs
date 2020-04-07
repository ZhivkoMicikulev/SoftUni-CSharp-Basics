using System;

namespace Задача2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i =  1; i <= 10;i++)
            {
                for (int h = 1; h <= 10; h++)
                {
                    Console.WriteLine($"{i} * {h} = {i * h}");
                }
            }
        }
    }
}
