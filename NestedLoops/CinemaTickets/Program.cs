using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            String movie = Console.ReadLine();
            int countStudent = 0;
            int countStandart = 0;
            int countKid = 0;
            int totalCount = 0;
            int movieCount = 0;
            
            while (movie!="Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                for (int i = 0; i <= freeSeats; i++)
                {
                    string ticketType = Console.ReadLine();
                    switch (ticketType)
                    {
                        case "student":
                            countStudent++;
                            movieCount++;
                            totalCount++;
                            break;
                            case "standard":
                            countStandart++;
                            movieCount++;
                            totalCount++;
                            break;
                            case "kid":
                            countKid++;
                            movieCount++;
                            totalCount++;
                            break;
                        case "End":
                            int left = freeSeats - movieCount;
                            i += left;
                            Console.WriteLine($"{movie} - {((double)movieCount / freeSeats) * 100:f2}% full.");
                            break;
                            
                            
                    }
                    if (movieCount == freeSeats)
                    {
                        Console.WriteLine($"{movie} - 100.00% full.");
                        break;
                    }
                    
                }
                movieCount = 0;
                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalCount}");
            Console.WriteLine($"{((double)countStudent / totalCount) * 100:f2}% student tickets.");
            Console.WriteLine($"{((double)countStandart / totalCount) * 100:f2}% standard tickets.");
            Console.WriteLine($"{((double)countKid / totalCount) * 100:f2}% kids tickets.");
        }
    }
}
