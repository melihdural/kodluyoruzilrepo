using System;

namespace ForEach_WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***While***");
            float sayi1 = float.Parse(Console.ReadLine());
            float sayac = 1;
            float toplam = 0;
            while (sayac<=sayi1)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.Write(toplam/sayi1);

            Console.WriteLine("***ForEach***");
            string[] mevsimler = {"ilkbahar","yaz","sonbahar","kış"};

            foreach (string m in mevsimler)
            {
                string mevsim = m;
                Console.WriteLine(mevsim);
            }

            Console.ReadKey();
                   
        }
    }
}
