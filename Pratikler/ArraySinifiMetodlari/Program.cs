using System;
using System.Collections.Generic;

namespace ArraySinifiMetodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayCakeCandles();           
            SimpleArraySum();
            Arrays();

            Console.ReadKey();
        }

        private static void Arrays()
        {
            Console.Write("Lütfen dizi boyutunu giriniz: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] numbers = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("Lütfen dizinin {0}. elemanını giriniz: ", i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
            Array.Reverse(numbers);

            

            foreach (var n in numbers)
            {
                Console.Write(n + " ");
            }


        }

        private static void SimpleArraySum()
        {
            int sum = 0;
            Console.Write("Lütfen dizi boyutunu giriniz: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] numbers = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("Lütfen dizinin {0}. elemanını giriniz: ", i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            foreach (var n in numbers)
            {
                sum+=n;                
            }

            Console.WriteLine("Dizi elemanlarınızın toplamı: " + sum + " kadardır.");


        }

        private static void BirthdayCakeCandles()
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

        }
    }
}
