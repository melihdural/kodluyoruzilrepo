using System;

namespace Csharpprogramlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi girin:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi girin:");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + surname);

            Console.ReadKey();
        }
    }
}
