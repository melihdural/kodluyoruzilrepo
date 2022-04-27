using System;

namespace MetotOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir(ifade,1,out int veriToplam);
            Console.WriteLine(veriToplam);


            Console.ReadKey();
        }
    }

    class Metotlar
    {
        public void Topla(int sayi1, int sayi2, out int toplamSonuc)
        {
            toplamSonuc = sayi1 + sayi2;   
        }

        //Metot Aşırı YÜkleme
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri1, int veri2, out int veriToplam)
        {
            veriToplam = veri1 + veri2;
        }
    }
}
