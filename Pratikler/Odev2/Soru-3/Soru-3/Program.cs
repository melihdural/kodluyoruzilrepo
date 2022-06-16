using System;
using System.Collections;

namespace Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            string vowels = "aeıioöuü";
            ArrayList matchingLetters = new ArrayList();
            Console.WriteLine("Bir cümle giriniz;");
            text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (text[i] == vowels[j])
                    {
                        matchingLetters.Add(text[i]);
                    }
                }
            }

            ArrayList repeatedVowels = new ArrayList();
            foreach (var mL in matchingLetters)
            {
                if (repeatedVowels.Contains(mL))
                {
                    continue;
                }
                repeatedVowels.Add(mL);
            }

            foreach (var item in repeatedVowels)
            {
                Console.Write("Cümledeki sesli harfler: " + item + " ");
            }        

        }
        
    }
}