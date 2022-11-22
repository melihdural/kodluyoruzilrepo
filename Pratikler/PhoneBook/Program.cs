using System;
using PhoneBook.Properties;

namespace PhoneBook
{
    partial class MainClass
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Lütfen Yapmak Istediginiz Islemi Seciniz!");
                Console.WriteLine("*****************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak﻿");

                var userInput = Int32.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        AddUser addUser = new AddUser();
                        addUser.UserAdd();
                        break;

                    case 2:
                        RemoveUser removeUser = new RemoveUser();
                        removeUser.UserRemove();
                        break;

                    case 3:
                        UpdateUser updateUser = new UpdateUser();
                        updateUser.UserUpdate();
                        break;

                    case 4:
                        ListUsers listUsers = new ListUsers(); 
                        listUsers.UserLists();
                        break;

                    case 5:
                        SearchUsers searchUsers = new SearchUsers();
                        searchUsers.UserSearch();
                        break;


                    default:
                        Console.WriteLine("Lütfen Gecerli Bir Secim Yapınız!");
                        break;

                }

            }

        }
    }
}
