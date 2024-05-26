using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Channels;

namespace phone
{
    using System;

    namespace YourNamespace
    {
        class Program
        {
            static void Main(string[] args)
            {
                PhoneBook phoneBook = new PhoneBook();
                phoneBook.AddContact("Oktay", " 051 727 48 98");
                phoneBook.AddContact("Ayhan", " 055 550 17 76");
                phoneBook.AddContact("Fazil", " 055 642 32 42");
                Console.WriteLine("All Contacts:");
                foreach (var contact in phoneBook.GetAllContacts())
                {
                    Console.WriteLine($"{contact.Value}");
                }
                Console.WriteLine("Find a contact:");
                Console.WriteLine(phoneBook.FindContactByName(Console.ReadLine()));

                Console.WriteLine("Remove a contact:");
                phoneBook.RemoveContact(Console.ReadLine());

                Console.WriteLine("All Contacts:");
                foreach (var contact in phoneBook.GetAllContacts())
                {
                    Console.WriteLine($"{contact.Value}");
                }
            }
        }

 
    }

}
