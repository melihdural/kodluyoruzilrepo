using System;
using System.Collections;

namespace Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isNumber;
            string temp;
            int lowestTotal = 0;
            int biggestTotal = 0;
            ArrayList numbers = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                while (true)
                {
                    Console.WriteLine("Pozitif bir sayı giriniz;");
                    temp = Console.ReadLine();
                    isNumber = int.TryParse(temp, out number);

                    if (isNumber==false || number<0)
                    {
                        Console.WriteLine("Lütfen pozitif bir sayı giriniz!");
                        continue;
                    }
                    else
                    {
                        numbers.Add(number);
                        break;;
                    }

                }
                
            }
            
            numbers.Sort();
            ArrayList lowest = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                lowest.Add(numbers[i]);
            }
            
            numbers.Reverse();
            ArrayList biggest = new ArrayList();

            for (int i = 0; i < 3; i++)
            {
                biggest.Add(numbers[i]);
            }
            
            Console.WriteLine("***** lowest *****");
            foreach (var l in lowest)
            {
                Console.WriteLine(l);
                lowestTotal += (int) l;
            }

            Console.WriteLine("The sum of the lowest number = " + lowestTotal);
            int averageLowest = lowestTotal / lowest.Count;
            Console.WriteLine("Average of lowest = " + averageLowest);


            Console.WriteLine("***** biggest *****");
            foreach (var b in biggest)
            {
                Console.WriteLine(b);
                biggestTotal += (int) b;
            }

            Console.WriteLine("The sum of the biggest numbers= " + biggestTotal);
            int averageBiggest = biggestTotal / biggest.Count;
            Console.WriteLine("Average of biggest = " + averageBiggest);
            
            Console.WriteLine("The sum of the Averages = " + (averageLowest+averageBiggest));

        }
    }
}