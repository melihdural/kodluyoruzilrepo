using System;
using System.Collections.Generic;

namespace PhoneBook.DataBase
{
    internal class CreateDatabase
    {
        private static List<Users> _phoneList;

        static CreateDatabase()
        {
            _phoneList = new List<Users>()

            {
                new Users { FirstName = "Asli", LastName = "Sutcuoglu", PhoneNumber = "(555) 542-2626" },
                new Users { FirstName = "Volkan", LastName = "Sutcuoglu", PhoneNumber = "(554) 550-4311" },
                new Users { FirstName = "Iffet", LastName = "Sutcuoglu", PhoneNumber = "(533) 185-8901" },
                new Users { FirstName = "Tahsin", LastName = "Sutcuoglu", PhoneNumber = "(506) 678-9012" },
                new Users { FirstName = "Burhan", LastName = "Altintop", PhoneNumber = "(542) 189-1033" }

            };
        }

        public static List<Users> PhoneList
        {
            get
            {
                return _phoneList;
            }
        }

    }

}
