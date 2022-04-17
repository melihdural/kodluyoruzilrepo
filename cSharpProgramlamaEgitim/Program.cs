using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Csharpprogramlama
{
    class Program
    {
        static void Main(string[] args)
        {
            #region İlk Ders
            //İlk Ders
            IlkDers();
            Console.WriteLine("İlk dersin sonu");
            #endregion
            
            #region İkinci Ders
            //İkinci Ders
            DegiskenlerDersiOdev();
            Console.WriteLine("İkinci dersin sonu");
            #endregion
            
            #region Üçüncü Ders
            //Üçüncü Ders
            Console.WriteLine("Yemek bedeli giriniz");
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());
            Console.WriteLine("Bahşiş bedeli giriniz");
            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());
            Console.WriteLine("Vergi bedeli giriniz");
            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

            UcuncuDers(meal_cost, tip_percent, tax_percent);
            #endregion

            Console.ReadKey();
        }

        private static void IlkDers()
        {
            //C# İlk Ders
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi girin:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi girin:");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + surname);

        }

        private static void DegiskenlerDersiOdev()
        {
            //HackerRank Sitesindeki 30 Days Challenge Day 1 Ödevi
            Console.WriteLine("Lütfen, 'Welcome to 30 Days of Code!' yazınız.");
            string inputString = Console.ReadLine();
            Console.WriteLine("Hello, World.");
            Console.WriteLine(inputString);
    

        }

        private static void UcuncuDers(double meal_cost, int tip_percent, int tax_percent)
        {
            //HackerRank Sitesindeki 30 Days Challenge Day 2 Ödevi
            double tipD = Convert.ToDouble(tip_percent);
            double taxD = Convert.ToDouble(tax_percent);
        
            double tip = (tipD/100)*meal_cost;
            double tax = (taxD/100)*meal_cost;
            double total_cost = meal_cost + tip + tax;
        
            int total = Convert.ToInt32(total_cost);
        
            Console.WriteLine(total);

       }


    }


}
