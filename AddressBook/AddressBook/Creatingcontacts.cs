using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CreatingContacts
    {
        List<contacts> People = new List<contacts>();



        public void Contacts()
        {
            contacts contact = new contacts();

            Console.WriteLine("Enter First Name : ");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter Email : ");
            contact.Email = Console.ReadLine();

            Console.WriteLine("Enter Phone Number : ");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("\n");


            People.Add(contact);


        }

        public void output()
        {
            foreach (var data in People)
            {

                Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                Console.WriteLine("Email ID : " + data.Email);
                Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                Console.WriteLine("\n");

            }

        }
    }
}