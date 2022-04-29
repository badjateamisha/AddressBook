
using AddressBook;

Console.WriteLine("Welcom to Address Book Program!");

CreatingContacts contact = new CreatingContacts();



while (true)
{
    Console.WriteLine("Enter the number :\n1)Creatingcontacts\n2)Edit Detaild\n3)Removing Details\n4)Output Details");
    int option = Convert.ToInt32(Console.ReadLine());
    switch(option)
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
            contact.output();
            break;
    }
}
