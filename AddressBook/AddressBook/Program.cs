
using AddressBook;

Console.WriteLine("Welcom to Address Book Program!");

CreatingContacts contact = new CreatingContacts();



while (true)
{
    Console.WriteLine("Enter the number :\n1)creatingcontacts\n2)Output Details");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            contact.Contacts();
            break;
        case 2:
            contact.output();
            break;
    }
}
