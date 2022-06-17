using System;

namespace Struck_Kavaramı
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen dikdörtgen = new Dikdörtgen();
            // dikdörtgen.kisaKenar=3;
            // dikdörtgen.uzunKenar = 4;

            Console.WriteLine("Class dikdörtgen alan hesabı: {0}", dikdörtgen.AlanHesapla());

            Dikdörtgen_struck dikdörtgenStruck;
            dikdörtgenStruck.kisaKenar = 3;
            dikdörtgenStruck.uzunKenar = 4;

            Console.WriteLine("Struck dikdörtgen alan hesabı: {0}", dikdörtgenStruck.AlanHesapla());

        }
    }

    class Dikdörtgen
    {
        public int kisaKenar;

        public int uzunKenar;

        public Dikdörtgen()
        {
            // struck için bu kullanım mümkün değil!!!
            kisaKenar = 3;
            uzunKenar = 4;
        }

        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }

    struct Dikdörtgen_struck
    {
        public int kisaKenar;

        public int uzunKenar;

        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }
}

