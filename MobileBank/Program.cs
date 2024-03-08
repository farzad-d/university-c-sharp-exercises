using System;

namespace MobileBank
{
    internal class Program
    {
    static void Main(string[] args)
    {
    HomePage home_page = new HomePage();
    UserData user = new UserData();
    Contact contact = new Contact();
    Load load = new Load();

    user.SignUp();
    bool logout = false;

    while(logout == false)
    {
    home_page.Menu(user.full_name);

    switch(home_page.user_choice)
    {
    case 1:
        user.ShowBalance();
        home_page.BackToHomePage();
        break;
    case 2:
        if(contact.ShowList())
        {
            Console.Write("\nSelect the contact number: ");
            short contact_id = short.Parse(Console.ReadLine()!);
            Console.Write("Enter the amount of money you want to transfer: $");
            double amount = double.Parse(Console.ReadLine()!);

            if(user.GetPassword())
            {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nTransfer ${amount} to {contact.contacts_list[contact_id-1].ContactName} with card number {contact.contacts_list[contact_id-1].CardNumber}\n");
            Console.ResetColor();
            Console.Write("Do you confirm the transaction info? (y/n): ");
            char answer = Convert.ToChar(Console.ReadLine()!);
            Console.Clear();

            switch(answer == 'y', user.BalanceCheck(amount))
            {
            case (true, true):
                load.Loading();
                user.UpdateBalance(amount);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nThe transaction was completed successfully.\n");
                Console.ResetColor();
                home_page.BackToHomePage();
                break;
            case (true, false):
                load.Loading();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYour account balance is not enough!\n");
                Console.ResetColor();
                home_page.BackToHomePage();
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThe transaction was cancelled.\n");
                Console.ResetColor();
                home_page.BackToHomePage();
                break;
            }
            }
            else
            home_page.BackToHomePage();
        }
        else
        home_page.BackToHomePage();
        break;
    case 3:
        contact.AddToList();
        break;
    case 4:
        contact.ShowList();
        home_page.BackToHomePage();
        break;
    case 5:
        user.ShowProfile();
        home_page.BackToHomePage();
        break;
    case 6:
        home_page.Logout();
        logout = true;
        break;
    default:
        home_page.WrongNumber();
        break;
        }
    }
    }
    }
}