using System;

namespace Kurucu_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SınıfAdı
            // {
            //      [Erişim Belirleyici] [Veri Tipi] Özellik Adı;
            //      [Erişim Belirleyici] [Geri Dönüş Tipi] Metod Adı (Parametre Listesi);
            //      {
            //          //Metot Komutları
            //      }
            // }
            
            // Erişim Belirleyiciler
            // * Public : Her yerden erişilebilir.
            // * Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
            // * Internal : Sadece bulunduğu proje içerisinden erişilebilir.
            // * Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

            Console.WriteLine("***** Çalışan 1 *****");
            Calisan calisan1 = new Calisan("Ayşe", "Kara", 15789552, "İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("***** Çalışan 2 *****");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Mehmet";
            calisan2.Soyad = "Sarı";
            calisan2.No = 12398752;
            calisan2.Departman = "Satın Alma";
            
            calisan2.CalisanBilgileri();

            Console.WriteLine("***** Çalışan 3 *****");
            Calisan calisan3 = new Calisan("Melih", "Dural");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;

        public string Soyad;

        public int No;

        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        
        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }
}
