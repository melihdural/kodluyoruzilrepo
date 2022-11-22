using System;
using System.Linq;
using PhoneBook.DataBase;

namespace PhoneBook
{
    internal class RemoveUser
    {
        internal void UserRemove()
        {
            while (true)
            { 
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz : ");
                string input = Console.ReadLine();

                if (CheckExist(input))
                {
                    Users removedUser = CreateDatabase.PhoneList.FirstOrDefault(x => x.FirstName == input || x.LastName == input);

                    bool confirmation = YesOrNo(removedUser);

                    if (confirmation)
                    {
                        CreateDatabase.PhoneList.Remove(removedUser);
                        Console.WriteLine("Kullanici basari ile silindi!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Silme islemi gerceklestirilemedi!");
                        break;
                    }

                }
                else
                {
                    if (NotExist() == 1)
                    {
                        break;
                    }
                }
            }


        }

        private int NotExist()
        {
            Console.WriteLine("Aradiginiz kriterlerde veri rehberinizde bulunamadi. Yeniden secim yapiniz.");
            int tempInput;

            while (true)
            {
                Console.WriteLine("*Silmeyi iptal edin : (1)");
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
                Console.WriteLine(user.FirstName + " " + user.LastName + " isimli kisiyi sileceksiniz, onayliyor musunuz ? Y/N");
                
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

        public bool CheckExist(string input)
        {
            bool exist = CreateDatabase.PhoneList.Any(x => x.FirstName == input || x.LastName == input);
                return exist;
        }
    }
}
