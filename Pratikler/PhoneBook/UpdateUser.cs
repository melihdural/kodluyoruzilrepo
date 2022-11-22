using System;
using System.Linq;
using PhoneBook.DataBase;

namespace PhoneBook
{
    internal class UpdateUser
    {
        internal void UserUpdate()
        {
            while (true)
            {
                Console.WriteLine("Lütfen numarasini guncellemek istediginiz kisinin adini ya da soyadini giriniz:");

                string input = Console.ReadLine();

                if (CheckExist(input))
                {
                    Users updatedUser = DataBase.CreateDatabase.PhoneList.FirstOrDefault(x => x.FirstName == input || x.LastName == input);

                    bool confirmation = YesOrNo(updatedUser);

                    if (confirmation)
                    {
                        Console.WriteLine("Lutfen guncel numarayi giriniz!");
                        string newNumber = Console.ReadLine();
                        updatedUser.PhoneNumber = newNumber;

                        Console.WriteLine("Kullanici basari ile guncellendi!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Guncelleme islemi gerceklestirilemedi!");
                        break;
                    }
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


        public bool CheckExist(string input)
        {
            bool exist = CreateDatabase.PhoneList.Any(x => x.FirstName == input || x.LastName == input);
            return exist;
        }

        private int NotExist()
        {
            Console.WriteLine("Aradiginiz kriterlerde veri rehberinizde bulunamadi. Yeniden secim yapiniz.");
            int tempInput;

            while (true)
            {
                Console.WriteLine("*Guncellemeyi iptal edin : (1)");
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

        private bool YesOrNo(Users user)
        {
            while (true)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName + " isimli kisiyi guncelleyeceksin, onayliyor musunuz ? Y/N");

                string option = Console.ReadLine().ToUpper();

                if (option == "Y")
                {
                    return true;
                }
                else if (option == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Gecersiz bir karakter girdiniz. Tekrar deneyiniz");
                }
            }

        }
    }
}
