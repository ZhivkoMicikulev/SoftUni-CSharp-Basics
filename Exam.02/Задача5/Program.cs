using System;

namespace Задача5
{
    class Program
    {
        static void Main(string[] args)
        {
            int soldGames = int.Parse(Console.ReadLine());
            int Hearthstone = 0;
            int Fornite = 0;
            int Overwatch = 0;
            int Others = 0;
            for (int i = 1; i <=soldGames; i++)
            {
                string name = Console.ReadLine();
                if (name == "Hearthstone") Hearthstone++;
                else if (name == "Fornite") Fornite++;
                else if (name == "Overwatch") Overwatch++;
                else if (name == "Fornite") Fornite++;
                else if (name != "Hearthstone" && name != "Fornite" && name != "Overwatch") Others++;
            }
            Console.WriteLine($"Hearthstone - {((double)Hearthstone / soldGames)*100:f2}%");
            Console.WriteLine($"Fornite - {((double)Fornite / soldGames)*100:f2}%");
            Console.WriteLine($"Overwatch - {((double)Overwatch / soldGames)*100:f2}%");
            Console.WriteLine($"Others - {((double)Others / soldGames)*100:f2}%");

        }
    }
}
