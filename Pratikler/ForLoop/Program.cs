﻿using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basamak oluşturmak için bir sayı giriniz!");
            int n = int.Parse(Console.ReadLine());
            StairCase(n);

            Console.ReadKey();
        }

        private static void StairCase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine(new string('#', i+1).PadLeft(n,' '));
                
                if(i==3)
                {
                    Console.WriteLine("i=3");
                    continue;
                }

                if(i>6)
                {
                    Console.WriteLine("i=6 loop concluded by break;");
                    break;
                }
            }
        }
    }
}
