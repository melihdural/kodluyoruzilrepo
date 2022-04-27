using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 8;

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(a+b));

            ornek.EkranaYazdir(Convert.ToString(ornek.ArttirVeTopla(a,b)));

            Console.ReadKey();
        }

        static int Topla(int deger1 , int deger2)
        {
            return deger1+deger2;
        }

    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(int deger1, int deger2)
        {
            deger1++;
            deger2++;
            return deger1+deger2;
        }
    }
}
