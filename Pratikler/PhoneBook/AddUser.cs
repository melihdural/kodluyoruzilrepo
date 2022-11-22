using System;
using System.Linq;
using PhoneBook.DataBase;

namespace PhoneBook.Properties
{
    internal class AddUser
    {
        
        internal void UserAdd()
        {
            Console.WriteLine("Lütfen isim giriniz : ");
            string name = Console.ReadLine();

            Console.WriteLine("Lütfen soyisim giriniz : ");
            string surname = Console.ReadLine();

            Console.WriteLine("Lütfen telefon numarası giriniz : ");
            string number = Console.ReadLine();

            Users person = new Users();

            person.FirstName = name;
            person.LastName = surname;
            person.PhoneNumber = number;

            CreateDatabase.PhoneList.Add(person);
            Console.WriteLine(name + " " + surname + " " + "Basariyla Kaydedildi!");
        }

        public bool CheckIsItExist(string input)
        {
            bool exist = CreateDatabase.PhoneList.Any(x => x.FirstName == input || x.LastName == input);
            return exist;

        }
    }
}
