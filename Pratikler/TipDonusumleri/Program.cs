using System;

namespace TipDonusumleri
{
    class Program
    {    

        static void Main(String[] args) 
        {
            //Implicit Conversion (Bilinçsiz Dönüşümler)
            Console.WriteLine("*** Implicit Conversion ***");

            byte b = 10;
            sbyte sb = 30;
            short sh = 50;

            int toplam1 = b+sb+sh;
            Console.WriteLine("toplam1: " + toplam1);

            long l = toplam1;
            Console.WriteLine("long l: " + toplam1);

            float f = l;
            Console.WriteLine("float f: " + l);

            string isim = "Melih";
            char c = isim[0];
            object obj = isim + c + f;
            Console.WriteLine("obj: " + obj);

            //Explicit Conversion(Bilinçli Dönüşümler)
            Console.WriteLine("***Explicit Conversion***");

            int i = 40;
            byte by = (byte)i;
            Console.WriteLine("by: " + by);

            float fl = 10.5f;
            byte byF = (byte)fl;
            Console.WriteLine("byF: " + byF);

            //ToString
            Console.WriteLine("*** ToString ***");
            int sayi1 = 1994;
            string string1 = sayi1.ToString();
            Console.WriteLine("string1: " + string1);

            //System.Convert
            Console.WriteLine(" *** System.Convert *** ");
            string s1 = "1994";
            string s2 = "2022";

            int sayiS1 = Convert.ToInt32(s1);
            int sayiS2 = Convert.ToInt32(s2);
            int yasiniz = sayiS2 - sayiS1;
            Console.WriteLine("Yaşınız: " + yasiniz);

            //Parse Method
            Console.WriteLine(" *** Parse Method *** ");
            ParseMethod();



            //HackerRank Challange
            Console.WriteLine("Bir sayı giriniz.");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Başka bir sayı giriniz.");
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1,val2);
            Console.WriteLine("Toplam: " + sum);


            Console.ReadKey();
        }

        private static void ParseMethod()
        {
            string metin1 = "15";
            string metin2 = "25,5";
            int rakam1;
            double double1;

            Console.WriteLine("rakam1: " + (rakam1 = Int32.Parse(metin1)));
            Console.WriteLine("double1: " + (double1 = Double.Parse(metin2)));
            




        }

        static int solveMeFirst(int a, int b)
         { 
            // Hint: Type return a+b; below  
            return a+b;
         }
    }
}
