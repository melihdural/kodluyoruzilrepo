using System;

namespace Sınıf_Kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 15789552;
            calisan1.Departman = "İnsanın Kaynakları";
            
            calisan1.CalisanBilgileri();

            Console.WriteLine("***************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Mehmet";
            calisan2.Soyad = "Sarı";
            calisan2.No = 12398752;
            calisan2.Departman = "Satın Alma";
            
            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;

        public string Soyad;

        public int No;

        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }
}