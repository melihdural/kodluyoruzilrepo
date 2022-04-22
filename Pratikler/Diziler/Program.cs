using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen dizi boyutunu giriniz: ");
            int diziBoyutu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziBoyutu];
            int negativeValues = 0;
            int positiveValues = 0;
            int zeros = 0;

            for (int i = 0; i < diziBoyutu; i++)
            {
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            foreach(var sayi in sayiDizisi)
            {
                if (sayi < 0)
                {
                    negativeValues++;
                    Console.WriteLine("negative: " + negativeValues);
                }
                else if (sayi > 0)
                {
                    positiveValues++;
                    Console.WriteLine("positive: " + positiveValues);

                }
                else if(sayi == 0)
                {
                    zeros++;
                    Console.WriteLine("zeros: " + zeros);

                }
            }

            double positiveRatio = (double)positiveValues/diziBoyutu;
            double negativeRatio = (double)negativeValues/diziBoyutu;
            double zeroRatio = (double)zeros/diziBoyutu;

            Console.WriteLine(string.Format("{0:0.000000}",positiveRatio));
            Console.WriteLine(string.Format("{0:0.000000}",negativeRatio));
            Console.WriteLine(string.Format("{0:0.000000}",zeroRatio));

            Console.ReadKey();
        }
    }
}
