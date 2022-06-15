using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string [] args)
        {
            //System.Collection.Generic namespace'ine bağlıdır
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            
            kullanicilar.Add(10, "Ayşe Yılmaz");
            kullanicilar.Add(12, "Ahmet Yılmaz");
            kullanicilar.Add(18, "Deniz Arda");
            kullanicilar.Add(20, "Özcan Coşar");
            
            //Elemanlara Erişim
            Console.WriteLine("***** Elemanlara Erişim *****");
            Console.WriteLine(kullanicilar[12]);

            foreach (var k in kullanicilar)
            {
                Console.WriteLine(k);
            }
            
            //Count
            Console.WriteLine("***** Count *****");
            Console.WriteLine(kullanicilar.Count);
            
            //Contains
            Console.WriteLine("***** Contains *****");
            Console.WriteLine(kullanicilar.ContainsKey(10));
            Console.WriteLine(kullanicilar.ContainsValue("Melih Dural"));
            
            //Remove
            Console.WriteLine("***** Remove *****");
            kullanicilar.Remove(12);

            foreach (var k in kullanicilar)
            {
                Console.WriteLine(k);
            }
            
            //Keys
            Console.WriteLine("***** Keys *****");

            foreach (var k in kullanicilar.Keys)
            {
                Console.WriteLine(k);
            }
            
            //Values
            Console.WriteLine("***** Values *****");

            foreach (var k in kullanicilar.Values)
            {
                Console.WriteLine(k);
            }



        }
    }
}