using System;

namespace PhoneBook
{
    internal class ListUsers
    {
        internal void UserLists()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("***************");

            for (int i = 0; i < DataBase.CreateDatabase.PhoneList.Count; i++)
            {
                Console.WriteLine("Isim : {0} ", DataBase.CreateDatabase.PhoneList[i].FirstName);
                Console.WriteLine("Soyisim : {0} ", DataBase.CreateDatabase.PhoneList[i].LastName);
                Console.WriteLine("Number : {0} ", DataBase.CreateDatabase.PhoneList[i].PhoneNumber);
                Console.WriteLine("---------------------------------------------------------------");

            }
        }
    }
}
