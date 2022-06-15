using System;
using System.Collections;

namespace Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isNumber;
            string entry;
            float totalPrimes = 0;
            float totalNonPrimes = 0;
            ArrayList prime = new ArrayList();
            ArrayList nonPrime = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                while (true)
                {

                    Console.WriteLine("Pozitif bir sayi giriniz: ");
                    entry = Console.ReadLine();

                    isNumber = int.TryParse(entry, out number);

                    if (isNumber==false || number<0)
                    {
                        Console.WriteLine("Girişiniz pozitif bir sayı olmalıdır");
                        Console.WriteLine("");
                        continue;
                    }
                    bool isPrime = IsPrime(number);
                    if (number == 1 || number == 0)
                    {
                        nonPrime.Add(number);
                        break;
                    }
                    if (isPrime)
                    {
                        prime.Add(number);
                        break;
                    }
                    else
                    {
                        nonPrime.Add(number);
                        break;
                    }
                }
            }
            
            prime.Sort();
            Console.WriteLine("***** Primes *****");

            foreach (var p in prime)
            {
                Console.WriteLine(p);
                totalPrimes += (int) p;
            }
            Console.WriteLine();
            
            nonPrime.Sort();
            Console.WriteLine("***** NonPrimes *****");

            foreach (var nP in nonPrime)
            {
                Console.WriteLine(nP);
                totalNonPrimes += (int) nP;
            }

            Console.WriteLine();
            Console.WriteLine("Primes: " + prime.Count + " Average of Primes= " + MathF.Round(totalPrimes/prime.Count) );
            Console.WriteLine("Non Primes: " +nonPrime.Count + " Average of Primes= " + MathF.Round(totalNonPrimes/nonPrime.Count) );
        }
        private static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i ==0)
                {
                    return false;
                }
            }
            

            return true;
        }
    }
}
