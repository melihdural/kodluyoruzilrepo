using System;
using System.Collections;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collection namespace'ini kullanıyor
            ArrayList list = new ArrayList();
            //
            // list.Add("Ayşe");
            // list.Add(26);
            // list.Add(true);
            // list.Add('A');
            //
            // Console.WriteLine(list[1]);
            //
            // foreach (var item in list)
            // {
            //     Console.WriteLine(item);
            // }
            
            //AddRange
            //
            // Console.WriteLine("****** AddRange ******");
            List<int> sayilar = new List<int>() {94, 28, 26, 2, 7, 9, 1, 71, 2002};
            list.AddRange(sayilar);
            //
            // string[] renkler = new[] {"kırmızı", "mavi", "yeşil", "mor", "sarı"};
            // list.AddRange(renkler);
            //
            // foreach (var item in list)
            // {
            //     Console.WriteLine(item);
            // }
            
            //Sort
            Console.WriteLine("****** Sort ******");
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
            //Binary Search
            Console.WriteLine("****** BinarySearch ******");
            Console.WriteLine(list.BinarySearch(94));
            
            //Reverse
            Console.WriteLine("****** Reverse ******");
            list.Reverse();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
            //Clear
            Console.WriteLine("****** Clear ******");
            list.Clear();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }



        }
    }
}

