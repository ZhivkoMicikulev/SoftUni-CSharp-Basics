using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayR = int.Parse(Console.ReadLine());
            int mR= int.Parse(Console.ReadLine());
            int dayN = int.Parse(Console.ReadLine());
            int mN = int.Parse(Console.ReadLine());
            int dayL = int.Parse(Console.ReadLine());
            int mL = int.Parse(Console.ReadLine());
            if (mR<mN)
            {
                double otstypka = (dayN - dayL) * 25;
                double krainaCena = otstypka - (otstypka * 0.2);
                Console.WriteLine($"Your stay from {dayN}/{mN} to {dayL}/{mL} will cost {-krainaCena:f2}");
            }
            else if (mR==mN && dayN-dayR>=10)
            {
                double otstypka = (dayN - dayL) * 25;
                
                Console.WriteLine($"Your stay from {dayN}/{mN} to {dayL}/{mL} will cost {-otstypka:f2}");
            }
            else
            {
                double otstypka = (dayN - dayL) * 30;

                Console.WriteLine($"Your stay from {dayN}/{mN} to {dayL}/{mL} will cost {-otstypka:f2}");
            }

        }
    }
}
