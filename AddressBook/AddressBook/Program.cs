// See https://aka.ms/new-console-template for more information
using AddressBook;

Console.WriteLine("Welcom to Address Book Program!");

Creatingcontacts contact = new Creatingcontacts();



while (true)
{
    Console.WriteLine("\nEnter the number :\n1)Creatingcontacts\n2)Edit Details\n3)Remove Contacts\n4)Adding multiple contacts\n5)Output Details\n6)Adding Unique Contacts\n7)Display unique contacts\n8)Search Person by city or State");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            contact.Contacts();
            break;
        case 2:
            contact.EditContacts();
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
            contact.Adduniquecontacts();
            break;
        case 7:
            contact.DisplayUniqueContacts();
            break;
        case 8:
            contact.SearchByCityState();
            break;
    }
}