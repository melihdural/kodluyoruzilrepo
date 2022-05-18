using System;

namespace ExtensionRekürsifMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif - Öz Yinelemeli
            
            Islemler instance = new();
            Console.WriteLine("Üst hesaplama");
            Console.WriteLine(instance.Expo(3,4));
            Console.WriteLine("Faktöriyel Hesaplama");
            Console.WriteLine(instance.Factorial(6));

            //Extension
            Console.WriteLine("Extension Metod Örnekleri");
            string ifade = "Melih Dural";
            bool sonuc = ifade.CheckSpaces();
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());
            

            Console.ReadKey();
        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if(üs<2)
                return sayi;
            return Expo(sayi, üs-1)*sayi;
        }

        public int Factorial(int sayi)
        {
            if (sayi == 0)
            {
                return 0;
            }
            else if (sayi == 1)
            {
                return 1;
            }
            else
            {
                return Factorial(sayi-1)*sayi;
            }
        }
    }

    public static class Extensions
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            string newString = string.Empty;
            char[] dizi = new char [param.Length];
            for (int i = 0; i < param.Length; i++)
            {
                if(char.IsLower(param[i]))
                {
                    dizi[i] = char.ToUpper(param[i]);                    
                }
                else
                {
                    dizi[i] = param[i];
                }
                newString += dizi[i];
                
            }
            
            return newString;        

        }

        public static string MakeLowerCase(this string param)
        {
            string newString = string.Empty;
            char[] dizi = new char [param.Length];
            for (int i = 0; i < param.Length; i++)
            {
                if(char.IsUpper(param[i]))
                {
                    dizi[i] = char.ToLower(param[i]);                    
                }
                else
                {
                    dizi[i] = param[i];
                }
                newString += dizi[i];
                
            }
            
            return newString;        

        }
        
        
    }
}
