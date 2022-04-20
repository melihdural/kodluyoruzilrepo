using System;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Yaşınızı giriniz: ");
                int yasiniz = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Yaşınız: " + yasiniz);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("İşleminiz tamamlandı");
            }

            Console.ReadKey();
        
        }
    }
}
