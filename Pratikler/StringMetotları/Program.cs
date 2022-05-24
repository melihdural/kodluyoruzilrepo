using System;

namespace StringMetotları
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Merhaba, benim adım Melih Dural. Hoşgeldiniz!";
            string degisken2 = "Melih Dural";

            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper-ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            
            //Concat
            Console.WriteLine(string.Concat(degisken, " Haydi Başlayalım!"));

            //Compare - CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(string.Compare(degisken,degisken2, true));
            
            //Equals
            Console.WriteLine(string.Equals(degisken, degisken2));

            //Contains
            Console.WriteLine(degisken.Contains("Melih"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));
            Console.WriteLine(degisken.EndsWith("Dural"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("Mel"));
            Console.WriteLine(degisken.IndexOf("Mert"));
            Console.WriteLine(degisken.LastIndexOf('e'));

            //Insert
            Console.WriteLine(degisken.Insert(0, "Aaa, "));

            //PadLeft - PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(40));
            Console.WriteLine(degisken.Remove(30, 10));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("Melih","Zeliş"));
            Console.WriteLine(degisken.Replace(' ', '*'));

            //Split
            Console.WriteLine(degisken.Split(' ')[3]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));
            

            Console.ReadLine();
        }
    }
}
