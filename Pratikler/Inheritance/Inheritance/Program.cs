using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //                            Canlılar
            //                               |
            //          Bitkiler                           Hayvanlar
            //      |             |                   |                 |
            //   Tohumlu       Tohumsuz          Sürüngenler          Kuşlar

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            //tohumlu bitkilerin constructor'ı bir defa çalışacağı için canlıların da özelliklerini yazdıracak.
            tohumluBitki.TohumlaCogalma();
            Console.WriteLine("*****************");
            
            Kuşlar martı = new Kuşlar();
            martı.Ucmak();
        }
    }
}