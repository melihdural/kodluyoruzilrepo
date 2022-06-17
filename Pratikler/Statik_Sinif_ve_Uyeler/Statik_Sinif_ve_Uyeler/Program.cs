using System;

namespace Statik_Sinif_ve_Uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toplam Çalışan Sayısı: {0}",Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Ayşe", "Yılmaz", "IK");

            Console.WriteLine("Toplam Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan2 = new Calisan("Mehmet", "Kara", "IK");
            Calisan calisan3 = new Calisan("Fatma", "Yolcu", "IK");

            Console.WriteLine("Toplam Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Console.WriteLine("İki sayının toplamı: {0}", Islemler.Topla(100,200));
            Console.WriteLine("İki sayının farkı: {0}", Islemler.Cikar(400,50));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        private string ad;

        private string soyad;

        private string departman;
        
        static Calisan(){}
        
        public Calisan(string ad, string soyad, string departman)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.departman = departman;
            calisanSayisi++;
        }

        public static int CalisanSayisi
        {
            get => calisanSayisi;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}