using System;

namespace Задача6
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            int numberOfSeatsOnOddColum = int.Parse(Console.ReadLine());
            int counter = 0;
            int real = numberOfSeatsOnOddColum;
            int counterColums = 0;
            for (int i = 65; i <=lastSector; i++)
            {
                for (int j = 1; j <= colums+counterColums; j++)
                {
                    if (j % 2 == 0)
                    {
                        real += 2;
                        for (int b = 97; b <= 96 + real; b++)
                        {
                            Console.WriteLine($"{(char)i}{j}{(char)b}");
                            counter++;
                        }
                    }
                    else
                    {
                        for (int h = 97; h <= numberOfSeatsOnOddColum + 96; h++)
                        {
                            Console.WriteLine($"{(char)i}{j}{(char)h}");
                            counter++;
                        }
                    }
                    real = numberOfSeatsOnOddColum;
                }
                
                counterColums++;

            }
            Console.WriteLine(counter);
        }
    }
}
