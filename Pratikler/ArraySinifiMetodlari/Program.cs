using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraySinifiMetodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // BirthdayCakeCandles();           
            // SimpleArraySum();
            // Arrays();
            // aVeryBigSum();
            // ComparaTriplets();
            // MigratoryBirds();

            



            Console.ReadKey();
        }

        private static void MigratoryBirds()
        {
            Console.Write("Lütfen toplam öten kuş sayısını giriniz: ");
            int totalBirds = int.Parse(Console.ReadLine());
            int[] birds = new int[totalBirds];
            bool birdIndexOk = false;

            for (int i = 0; i < totalBirds; i++)
            {
                Console.Write("Lütfen öten kuşun numarasını(1-5 arasında) giriniz: ");
                birds[i] = int.Parse(Console.ReadLine());
            }

            int[] types = new int[5];
            foreach (var b in birds)
            {
                switch (b)
                {
                    case 1:
                        types[0]++;
                        break;
                    case 2:
                        types[1]++;
                        break;
                    case 3:
                        types[2]++;
                        break;
                    case 4:
                        types[3]++;
                        break;
                    case 5:
                        types[4]++;
                        break;

                }
                                
            }
            
            int result= Array.IndexOf(types,types.Max() )+1;
            Console.WriteLine("En çok öten kuş türü {0}. tür.",result);
            

        }

        private static void ComparaTriplets()
        {
            int[] a = new int [3];
            int[] b = new int [3];
            int aTotalPoint = 0;
            int bTotalPoint = 0;

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Lütfen Alice'in {0}. koşul için puanını giriniz: ", i+1);
                a[i] = int.Parse(Console.ReadLine());
                Console.Write("Lütfen Bob'un {0}. koşul için puanını giriniz: ", i+1);
                b[i] = int.Parse(Console.ReadLine());

                if(a[i]<b[i])
                {
                    bTotalPoint++;
                }
                else if(a[i]>b[i])
                {
                    aTotalPoint++;
                }
            }

            int[] scoreBoard = { aTotalPoint, bTotalPoint};
            Console.WriteLine("Alice: {0} - Bob: {1}", aTotalPoint, bTotalPoint);
        }

         private static void aVeryBigSum()
        {
            Console.Write("Lütfen dizi boyutunu giriniz: ");
            int arraySize = int.Parse(Console.ReadLine());
            long[] bigNums = new long[arraySize];
            long sum = 0;

                for (int i = 0; i < arraySize; i++)
                {
                    Console.Write("Lütfen dizinin {0}. elemanına long türünde bir sayı giriniz: ", i+1);
                    bigNums[i] = int.Parse(Console.ReadLine());
                }

                foreach (var b in bigNums)
                {
                    sum += b;
                }

                Console.WriteLine(sum);

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
