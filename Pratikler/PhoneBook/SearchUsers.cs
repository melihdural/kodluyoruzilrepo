using System;
using System.Linq;
using PhoneBook.DataBase;

namespace PhoneBook
{
    internal class SearchUsers
    {
        internal void UserSearch()
        {
            while (true)
            {
                Console.WriteLine("Arama yapmak istediginiz tipi seciniz.");
                Console.WriteLine("**************************************");

                Console.WriteLine("Isim veya soyisime göre arama yapmak icin: (1)");
                Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                Console.WriteLine("**************************************");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("Lütfen numarasini bulmak istediginiz kisinin adini ya da soyadini giriniz : ");
                        string inputNameOrSurname = Console.ReadLine();

                        if (CheckExist(inputNameOrSurname))
                        {
                            Users searchedUser = CreateDatabase.PhoneList.FirstOrDefault(x => x.FirstName == inputNameOrSurname || x.LastName == inputNameOrSurname);

                            Show(searchedUser);
                        }
                        else
                        {
                            if (NotExist() == 1)
                            {
                                return;
                            }
                        }
                        

                    }
                }
                else if (input == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("Lütfen bulmak istediginiz kişinin numarasini giriniz : ");
                        string inputNumber = Console.ReadLine();
                        foreach (Users item in CreateDatabase.PhoneList)
                        {
                            if (item.PhoneNumber.Contains(inputNumber))
                            {
                                Show(item);
                            }
                            else
                            {
                                if (NotExist() == 1)
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Gecersiz bir giris yaptınız. Yeniden deneyiniz!");
                }

            }
        }

        

        private bool CheckExist(string input)
        {
            bool exist = CreateDatabase.PhoneList.Any(x => x.FirstName == input || x.LastName == input || x.PhoneNumber == input);
            return exist;
        }

        private bool CheckNumExist(string input)
        {
            bool exist = CreateDatabase.PhoneList.Any(x => x.PhoneNumber == input);
            return exist;
        }

        private int NotExist()
        {
            Console.WriteLine("Aradiginiz kriterlerde veri rehberinizde bulunamadi. Yeniden secim yapiniz.");
            int tempInput;

            while (true)
            {
                Console.WriteLine("*Aramayi iptal edin : (1)");
                Console.WriteLine("*Yeniden deneyiniz  : (2)");

                if (int.TryParse(Console.ReadLine(), out tempInput))
                {
                    if (tempInput == 1)
                    {
                        return 1;
                    }
                    else if (tempInput == 2)
                    {
                        return 2;
                    }
                }
                else
                {
                    Console.WriteLine("Gecersiz bir karakter girdiniz. Tekrar deneyiniz ");
                }
            }
        }

        void Show(Users user)
        {
            Console.WriteLine(user.FirstName);
            Console.WriteLine(user.LastName);
            Console.WriteLine(user.PhoneNumber);
            Console.WriteLine("__________________");
        }

    }
}
