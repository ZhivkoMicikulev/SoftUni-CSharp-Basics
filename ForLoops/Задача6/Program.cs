﻿using System;

namespace Задача6
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i=1;i<=tabs;i++)
            {
                string web = Console.ReadLine();
                switch (web)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
                if (salary<=0)
                {
                    break;
                }
            }
        if (salary<=0)
            {
                Console.WriteLine("You have lost your salary.");
            }
        else
            {
                Console.WriteLine(salary);
            }
        }

    }
}
