using System;

namespace ИзпитнаГенераторЗаПароли
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n ; i++)
            {
                for (int j = 1; j <=n; j++)
                {
                    for (int h =97; h <=l+96; h++)
                    {
                        
                        for (int t =97; t <=l+96; t++)
                        {
                            for (int e=1; e <=n; e++)
                            {
                                if (e>i && e>j)
                                {
                                    Console.Write($" {i}{j}{(char)h}{(char)t}{e}");
                                }
                                
                            }
                        }
                    }
                }
            }
        }
    }
}
