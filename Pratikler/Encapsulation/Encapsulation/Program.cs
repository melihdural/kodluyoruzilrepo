using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = "Melih";
            ogrenci1.Soyad = "Dural";
            ogrenci1.OgrenciNo = 119;
            ogrenci1.Sinif = 3;
            
            ogrenci1.OgrenciBilgileri();
            
            ogrenci1.SinifAzalt();
            ogrenci1.SinifAzalt();
            ogrenci1.SinifAzalt();
            ogrenci1.OgrenciBilgileri();

        }
    }

    class Ogrenci
    {
        private string ad;

        private string soyad;

        private int ogrenciNo;

        private int sinif;

        public string Ad
        {
            get => ad;
            set => ad = value;
        }

        public string Soyad
        {
            get => soyad;
            set => soyad = value;
        }

        public int OgrenciNo
        {
            get => ogrenciNo;
            set => ogrenciNo = value;
        }

        public int Sinif
        {
            get => sinif;
            set
            {
                if (value<1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
            }
        }
        
        public Ogrenci(){}

        public Ogrenci(string ad, string soyad, int ögrenciNo, int sinif)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.OgrenciNo = ogrenciNo;
            this.Sinif = sinif;
        }

        public void OgrenciBilgileri()
        {
            Console.WriteLine("********** Ogrenci Bilgileri **********");
            Console.WriteLine("Ogrencinin adı:      {0}",this.Ad);
            Console.WriteLine("Ogrencinin soyadı:      {0}",this.Soyad);
            Console.WriteLine("Ogrencinin okul numarası:      {0}",this.OgrenciNo);
            Console.WriteLine("Ogrencinin sınıfı:      {0}",this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif += 1;
        }

        public void SinifAzalt()
        {
            this.Sinif -= 1;
        }
    }
}