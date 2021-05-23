using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Address Book System ADO.NET");

            AddressBookManagement addressBookManagement = new AddressBookManagement();

            addressBookManagement.DataBaseConnection(); //UC1
            Console.ReadLine();
        }
    }
}
