using System;

namespace Csharpprogramlama
{
    class Program
    {
        static void Main(string[] args)
        {
            IlkDers();
            Console.WriteLine("İlk dersin sonu");
            DegiskenlerDersiOdev();
            Console.WriteLine("İkinci dersin sonu");
            
            
            Console.ReadKey();
        }

        private static void IlkDers()
        {
            //C# İlk Ders
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi girin:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi girin:");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + surname);

        }

        
        private static void DegiskenlerDersiOdev()
        {
            //HackerRank sitesindeki ödevin bir örneği
            Console.WriteLine("Lütfen, 'Welcome to 30 Days of Code!' yazınız.");
            string inputString = Console.ReadLine();
            Console.WriteLine("Hello, World.");
            Console.WriteLine(inputString);
    

        }

    }

}
