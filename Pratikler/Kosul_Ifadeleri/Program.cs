using System;

namespace Kosul_Ifadeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            IfElse();
            SwitchCase();

            Console.ReadKey();
        }

        private static void SwitchCase()
        {
            int month = DateTime.Now.Month;
            int season = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                Console.WriteLine("Ocak ayındasınız");
                break;

                case 2:
                Console.WriteLine("Şubat ayındasınız");
                break;

                case 3:
                Console.WriteLine("Mart ayındasınız");
                break;

                case 4:
                Console.WriteLine("Nisan ayındasınız");
                break;

                case 5:
                Console.WriteLine("Mayıs ayındasınız");
                break;

                case 6:
                Console.WriteLine("Haziran ayındasınız");
                break;

                case 7:
                Console.WriteLine("Temmuz ayındasınız");
                break;

                case 8:
                Console.WriteLine("Ağustos ayındasınız");
                break;

                case 9:
                Console.WriteLine("Eylül ayındasınız");
                break;

                case 10:
                Console.WriteLine("Ekim ayındasınız");
                break;

                case 11:
                Console.WriteLine("Kasım ayındasınız");
                break;

                case 12:
                Console.WriteLine("Aralık ayındasınız");
                break;

                default:
                Console.WriteLine("Tarih Okunamadı.");
                break;

            }

            switch(season)
            {
                case 12:
                Console.WriteLine("Kış Mevsimindesiniz");
                break;

                case 1:
                Console.WriteLine("Kış Mevsimindesiniz");
                break;

                case 2:
                Console.WriteLine("Kış Mevsimindesiniz");
                break;

                case 3:
                Console.WriteLine("Bahar Mevsimindesiniz");
                break;

                case 4:
                Console.WriteLine("Bahar Mevsimindesiniz");
                break;

                case 5:
                Console.WriteLine("Bahar Mevsimindesiniz");
                break;

                case 6:
                Console.WriteLine("Yaz Mevsimindesiniz");
                break;

                case 7:
                Console.WriteLine("Yaz Mevsimindesiniz");
                break;

                case 8:
                Console.WriteLine("Yaz Mevsimindesiniz");
                break;

                case 9:
                Console.WriteLine("Sonbahar Mevsimindesiniz");
                break;

                case 10:
                Console.WriteLine("Sonbahar Mevsimindesiniz");
                break;

                case 11:
                Console.WriteLine("Sonbahar Mevsimindesiniz");
                break;

                default:
                Console.WriteLine("Tarih Okunamadı.");
                break;

            }


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
