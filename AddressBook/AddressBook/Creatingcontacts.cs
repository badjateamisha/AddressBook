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
        public Dictionary<string, List<contacts>> dict = new Dictionary<string, List<contacts>>();


        public void Contacts()
        {
            contacts contact = new contacts();

            Console.WriteLine("Enter First Name : ");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter Address : ");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter City : ");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter Zip : ");
            contact.Zip = Console.ReadLine();

            Console.WriteLine("Enter State : ");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter Email : ");
            contact.Email = Console.ReadLine();

            Console.WriteLine("Enter Phone Number : ");
            contact.PhoneNumber = Console.ReadLine();

            Console.WriteLine("\n");

            People.Add(contact);

        }


        public void EditDetails()
        {
            Console.WriteLine("Enter the name to search : ");
            string name = Console.ReadLine();
            foreach (var data in People)
            {
                if (data.FirstName == null)
                {
                    Console.WriteLine("Contact for {0} count not be found.", name);
                }
                else if (data.FirstName == name)
                {
                    Console.WriteLine("choose the option to change the data : \n1)FirstName\n2)LastName\n3)Email\n4)Phone Number\n5)Address\n6)City\n7)Zip\n8)State");
                    int choose = Convert.ToInt32(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            Console.WriteLine("Please enter the First Name : ");
                            string firstName = Console.ReadLine();
                            data.FirstName = firstName;
                            break;
                        case 2:
                            Console.WriteLine("Please enter the Last Name : ");
                            string lastName = Console.ReadLine();
                            data.LastName = lastName;
                            break;
                        case 3:
                            Console.WriteLine("Please enter the Email : ");
                            string Email = Console.ReadLine();
                            data.Email = Email;

                            break;
                        case 4:
                            Console.WriteLine("Please enter the Phone Number : ");
                            string PhoneNumber = Console.ReadLine();
                            data.PhoneNumber = PhoneNumber;
                            break;
                        case 5:
                            Console.WriteLine("Please enter the Address : ");
                            string address = Console.ReadLine();
                            data.Address = address;
                            break;
                        case 6:
                            Console.WriteLine("Please enter the city : ");
                            string city = Console.ReadLine();
                            data.City = city;
                            break;
                        case 7:
                            Console.WriteLine("Please enter the zip Code : ");
                            string Zip = Console.ReadLine();
                            data.Zip = Zip;
                            break;
                        case 8:
                            Console.WriteLine("Please enter the state : ");
                            string State = Console.ReadLine();
                            data.State = State;
                            break;
                        default:
                            Console.WriteLine(" Wrong input,Please choose from above options : ");
                            break;
                    }

                }

            }
        }

        public void RemoveContact()
        {
            Console.WriteLine("Enter the name to search : ");
            string name = Console.ReadLine();
            try
            {
                foreach (var data in People)
                {
                    if (People.Contains(data))
                    {
                        if (data.FirstName == name)
                        {
                            Console.WriteLine("given name contact exists");
                            People.Remove(data);

                            Console.WriteLine("contact deleted successfully");
                            return;
                        }
                    }
                }
                Console.WriteLine("given name contact does not exists");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Addmultiplepersons(int n)
        {
            while (n > 0)
            {
                Contacts();
                n--;
            }

        }
        public void Adduniquecontacts()
        {
            Console.WriteLine("Enter the Firstname in your contactlist");
            string name = Console.ReadLine();
            foreach (var data in People)
            {
                if (People.Contains(data))
                {
                    if (data.FirstName == name)
                    {
                        Console.WriteLine("This contact exists please enter an unique name to store this data");
                        string uniquename = Console.ReadLine();
                        if (dict.ContainsKey(uniquename))
                        {
                            Console.WriteLine("This unique name already exists");
                        }
                        dict.Add(uniquename, People);
                        return;
                    }
                }


            }
            Console.WriteLine("This contactlist doesn't exist, please creat a contactlist");
            return;

        }


        public void DisplayUniqueContacts()
        {
            Console.WriteLine("Enter the Uniquename of your contacts");
            string name = Console.ReadLine();


            foreach (var contacts in dict)
            {
                if (contacts.Key.Contains(name))
                {

                    foreach (var contact in contacts.Value)
                    {
                        Console.WriteLine("The details of " + name + " are \n" + "Name: " + contact.FirstName + " " + contact.LastName + "\n" + "Email: " + contact.Email + "\n" +
                            "Phone Number: " + contact.PhoneNumber + "\n" + "Address: " + contact.Address + "\n" + "city: " + contact.City + "\n" + "Zip: " + contact.Zip + "\n" + "state: " + contact.State);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("this unique name doesn't exist");
                }

            }
            Console.WriteLine("This Uniquelist doesn't exist, please creat a Uniquelist");
        }


        public void output()
        {
            foreach (var data in People)
            {

                Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                Console.WriteLine("Email ID : " + data.Email);
                Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                Console.WriteLine("Address : " + data.Address);
                Console.WriteLine("City : " + data.City);
                Console.WriteLine("Zip : " + data.Zip);
                Console.WriteLine("State : " + data.State);
                Console.WriteLine("\n");

            }

        }
    }
}
