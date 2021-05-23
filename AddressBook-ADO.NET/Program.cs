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

           //addressBookManagement.DataBaseConnection(); //UC1
           
          // addressBookManagement.GetAllContact(); //UC2

           // AddNewContactDetails(); //UC3
           
            
            
            
            Console.ReadLine();
        }
        /* UC3:- Ability to insert new Contacts to Address Book */
        public static void AddNewContactDetails()
        {
            AddressBookManagement repository = new AddressBookManagement();
            AddressBookModel model = new AddressBookModel();
            model.FirstName = "Ekta";
            model.LastName = "Kumbhare";
            model.Address = "Aundh";
            model.City = "Pune";
            model.State = "Maharashtra";
            model.Zip = "412105";
            model.PhoneNumber = "1234567891";
            model.EmailId = "ekta@gmail.com";
            model.AddressBookType = "Friend";
            model.AddressBookName = "Ekta";
           
            Console.WriteLine(repository.AddDataToTable(model) ? "Record inserted successfully\n" : "Record inserted Failed");
        }
    }
}
