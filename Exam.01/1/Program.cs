using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohod = double.Parse(Console.ReadLine());
            int mesec = int.Parse(Console.ReadLine());
            double lRazhodi = double.Parse(Console.ReadLine());
            double speshniRazhodi = dohod * 0.3;
            double izlishyk = dohod - (lRazhodi + speshniRazhodi);
            double izlishykPro = (izlishyk / dohod) * 100;
            double izlishykCql = izlishyk * mesec;
            Console.WriteLine($"She can save {izlishykPro:f2}%");
            Console.WriteLine($"{izlishykCql:f2}");
        }
    }
}
