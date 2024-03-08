class HomePage
{
    public static string logo = @"  ______                      _   ____              _    
 |  ____|                    | | |  _ \            | |   
 | |__ __ _ _ __ ______ _  __| | | |_) | __ _ _ __ | | __
 |  __/ _` | '__|_  / _` |/ _` | |  _ < / _` | '_ \| |/ /
 | | | (_| | |   / / (_| | (_| | | |_) | (_| | | | |   < 
 |_|  \__,_|_|  /___\__,_|\__,_| |____/ \__,_|_| |_|_|\_\
                                                        ";
    

    public string menu = "     [1] Show balance\t\t[2] Mony transfer\n     [3] Add contact\t\t[4] Contact list\n     [5] Show profile\t\t[6] Logout\n\nPlease enter the item number: ";
    public short user_choice;

    public void Menu(string name)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(logo);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"  Welcome {name}\n");
        Console.ResetColor();
        Console.Write(menu);
        user_choice = short.Parse(Console.ReadLine()!);
    }
    public void WrongNumber()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[Error]\nIncorrect item number!");
        Console.ResetColor();
        System.Threading.Thread.Sleep(1500);
    }

    public void Logout()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(logo);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n\tYou are logged out of your account.\n");
        Console.ResetColor();
    }
    public void BackToHomePage()
    {
        ConsoleKeyInfo keypress;
        do
        {
            Console.Write("\nPress 'Escape' to return to the home page");
            keypress = Console.ReadKey();
        }
        while(keypress.Key != ConsoleKey.Escape);
    }
}