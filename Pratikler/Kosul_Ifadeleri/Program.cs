using System;

namespace Kosul_Ifadeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            IfElse();

            Console.ReadKey();
        }

        private static void IfElse()
        {
             Console.WriteLine("Bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            if(n%2!=0)
            {
                Console.WriteLine("Weird");
            }

            if(n%2==0 && 2<n && n<5)
            {
                Console.WriteLine("Not Weird");
            }

            if(n%2==0 && 6<n && n<=20)
            {
                Console.WriteLine("Weird");
            }

            if(n%2==0 && n>20)
            {
                Console.WriteLine("Not Weird");
            }

        }
    }
}
