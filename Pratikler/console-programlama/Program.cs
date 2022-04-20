using System;

namespace IlkDers
{
    class Program
    {
        static void Main(string[] args)
        {
            IlkDers();

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
    }
}
