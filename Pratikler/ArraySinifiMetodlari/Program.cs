using System;
using System.Collections.Generic;

namespace ArraySinifiMetodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lürfen dizi boyutunu giriniz: ");
            int candlesCount = int.Parse(Console.ReadLine());
            int[] candles = new int[candlesCount];
            int result = 0;
            int maxHeight = 0;

            for (int i = 0; i < candlesCount; i++)
            {
                Console.Write("Lütfen {0}. mumun yüksekliğini giriniz: ", i+1);
                candles[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(candles);

            maxHeight = candles[candlesCount-1];

            foreach (var c in candles)
            {
                if(c==maxHeight)
                {
                    result++;
                }                
            }

            Console.WriteLine("Üflenebilir mum adedi " + result + " kadardır.");



            Console.ReadKey();
        }
    }
}
