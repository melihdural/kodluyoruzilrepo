namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic
            // T=> object türündedir

            List<int> sayiListesi = new List<int>();
            
            sayiListesi.Add(26);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");
            
            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);
            
            //Foreach ve List.Foreach
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            
            renkListesi.ForEach(renk=> Console.WriteLine(renk));
            
            //Listeden Eleman Çıkarma
            sayiListesi.Remove(10);
            
            sayiListesi.RemoveAt(1);
            
            //Liste içerisinde eleman arama
            if (renkListesi.Contains("Kırmızı"))
            {
                Console.WriteLine("Kırmızı bulundu");
            }
            
            //Eleman ile indexe erişme
            renkListesi.BinarySearch("Turuncu");
            
            //Diziyi Listeye çevirmek
            string[] hayvanlar = {"Kedi", "Köpek", "Balık"};
            List<string> hayvanlarListesi = new List<string>(hayvanlar);
            
            //Listeyi temizlemek
            hayvanlarListesi.Clear();
            
            
            //Liste içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.İsim = "Melih";
            kullanici1.Soyisim = "Dural";
            kullanici1.Yasi = 28;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.İsim = "İzem";
            kullanici2.Soyisim = "Dural";
            kullanici2.Yasi = 20;
            
            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar() {İsim = "Koray", Soyisim = "Altunok", Yasi = 32});
            
            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanici Adi: " + kullanici.İsim);
                Console.WriteLine("Kullanici Soyadi: " + kullanici.Soyisim);
                Console.WriteLine("Kullanici Yasi: " + kullanici.Yasi);
                Console.WriteLine("---------------------------------");
            }
            
        }
    }

    class Kullanicilar
    {
        private string? isim;

        private string? soyisim;

        private int yasi;

        public int Yasi
        {
            get => yasi;
            set => yasi = value;
        }

        public string? Soyisim
        {
            get => soyisim;
            set => soyisim = value;
        }

        public string? İsim
        {
            get => isim;
            set => isim = value;
        }


    }
    
}