class Contact
{
    private string contact_name;
    private int contact_id = 0;
    private string card_number;
    public Contact[] contacts_list = new Contact[0];
    public string ContactName
    {
        get { return contact_name;}
        set { contact_name = value;}
    }
    public string CardNumber
    {
        get { return card_number;}
        set { card_number = value;}
    }
    public int ContactID
    {
        get{return contact_id;}
        set{contact_id = value;}
    }
    public void AddToList()
    {
        Console.Clear();
        Console.Write("How many contacts do you want to add? ");
        short contacts_num = short.Parse(Console.ReadLine()!);
        Console.WriteLine();

        contacts_list = new Contact[contacts_num];

        for(int i = 0; i < contacts_num; i++)
        {
            Contact new_contact = new Contact();
            Console.Write("Enter contact name: ");
            new_contact.ContactName = Console.ReadLine()!;
            Console.Write("Enter contact card number: ");
            new_contact.CardNumber = Console.ReadLine()!;
            Console.WriteLine();
            new_contact.ContactID = i+1;
            contacts_list[i] = new_contact;
        }
    }

    public bool ShowList()
    {
        Console.Clear();
        Console.WriteLine("\n\tName\t\t\tCard number");
        Console.WriteLine("==================================================");
        foreach(var item in contacts_list)
        {
            Console.WriteLine($"[{item.ContactID}]\t{item.ContactName}\t\t{item.CardNumber}");
        }
        Console.WriteLine();
        if(contacts_list.Length == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your contact list is empty!\n");
            Console.ResetColor();
            return false;
        }
        else
            return true;
    }
}