using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odevler.Odev1();   
            Odevler.Odev2();  
            Odevler.Odev3();       
            Odevler.Odev4();
            
            
            Console.ReadKey();
        }
    }

    class Odevler
    {
        public static void Odev1()
        {
            Console.WriteLine("Pozitif bir sayı giriniz!");
            int n = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[n];
            // int[] ciftSayilarDizisi = {};
            Console.WriteLine("{0} adet pozitif sayi giriniz!", n);
            for (int i = 0; i < n; i++)
            {
                sayiDizisi[i] = int.Parse(Console.ReadLine());
                Console.Write("{0}. sayi = {1}", i+1, sayiDizisi[i]);
            }
            for (int j = 0; j < sayiDizisi.Length; j++)
            {
                if (sayiDizisi[j]%2==0)
                {
                    Console.WriteLine("Belirlediğiniz {0}. sayi = {1}, bir çift sayidir.", j+1, sayiDizisi[j]);
                }
            }
            

        }

        public static void Odev2()
        {
            Console.WriteLine("Pozitif 2 adet sayi giriniz!");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("{0} adet pozitif sayi giriniz!", n);
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}. sayi = {1}", i+1, numbers[i]);
            }
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j]%m==0 || numbers[j]==m)
                {
                    Console.WriteLine("Belirlediğiniz {0}. sayi = {1}, {2}'e eşit veya katıdır.", j+1, numbers[j], m);
                }
            }
        }

        public static void Odev3()
        {
            Console.WriteLine("Pozitif bir sayi giriniz!");
            int n = int.Parse(Console.ReadLine());
            string[] kelimeDizisi = new string[n];
            Console.WriteLine("{0} adet kelime giriniz.", n);
            for (int i = 0; i < n; i++)
            {
                kelimeDizisi[i] = Console.ReadLine();
                Console.WriteLine("{0}. kelime : {1}", i+1, kelimeDizisi[i]);
            }
            Array.Reverse(kelimeDizisi);
            Console.WriteLine("Yeni sırasıyla kelimeler;");
            foreach (var k in kelimeDizisi)
            {
                int i = 1;
                Console.WriteLine("{0}. kelime : {1}", i, k);
                i++;
            }
            
        }

        public static void Odev4()
        {
            Console.WriteLine("Bir cümle giriniz!");
            string cumle = Console.ReadLine();
            int harfSayisi = cumle.RemoveWhiteSpaces().Length;
            Console.WriteLine("Toplam harf sayısı= " + harfSayisi);
            string[] dizi = cumle.Split(" ");
            Console.WriteLine("Toplam kelime sayısı= "+ dizi.Length);
        }
        
    }

    public static class Extension
    {
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }
    }
}
