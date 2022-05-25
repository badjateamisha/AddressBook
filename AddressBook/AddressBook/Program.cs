
using AddressBook;

Console.WriteLine("Welcome to Address Book Program!");

CreatingContacts contact = new CreatingContacts();



while (true)
{
    Console.WriteLine("Enter the number :\n1)Creating Contacts\n2)Edit Details\n3)Remove Contacts\n4)Adding multiple contacts\n5)Output Details\n6)Adding Unique Contacts\n7)Display Unique Contacts");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            contact.Contacts();
            break;
        case 2:
            contact.EditDetails();
            break;
        case 3:
            contact.RemoveContact();
            break;
        case 4:
            Console.WriteLine("Enter the number of contacts you want");
            int n = Convert.ToInt32(Console.ReadLine());
            contact.Addmultiplepersons(n);
            break;
        case 5:
            contact.output();
            break;
        case 6:
            break;
        case 7:
            contact.DisplayUniqueContacts();
            break;
    }
}