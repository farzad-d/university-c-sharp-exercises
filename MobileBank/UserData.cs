class UserData
{
    public string full_name;
    public string card_number;
    public string tel; 
    private string password;
    private double balance;

    public string Password
    {
        get{return password;}
        set{password = value;}
    }
    public double Balance
    {
        get{return balance;}
        set{balance = value;}
    }
    public void SignUp()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\tHello dear user!\n  To use this app you need to create an account.\n");
        Console.ResetColor();
        Console.Write("Enter your full name: ");
        full_name = Console.ReadLine()!;
        Console.Write("Enter your card number: ");
        card_number = Console.ReadLine()!;
        Console.Write("Enter your phone number: ");
        tel = Console.ReadLine()!;

        bool same_pass = false;
        while(same_pass == false)
        {
            Console.Write("Enter a strong password: ");
            string pass = Console.ReadLine()!;
            Console.Write("Repeat the password: ");
            string repeat_pass = Console.ReadLine()!;
            if(pass == repeat_pass)
            {
                same_pass = true;
                Password = pass;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[WARNING!]\nYour passwords are not the same! Try again.");
                Console.ResetColor();
            }
        }
        Console.Write("How much do you want to invest? $");
        Balance = double.Parse(Console.ReadLine()!);
    }
    public void ShowBalance()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nYour account balance is: ${Balance}");
        Console.ResetColor();
    }
    public bool BalanceCheck(double amount)
    {
        double assume_bl = Balance;
        switch((assume_bl - amount) >= 0)
        {
            case(true):
            return true;
            case(false):
            return false;
        }
    }
    public void UpdateBalance(double amount)
    {
        Balance -= amount;
    }
    public bool GetPassword()
    {
        Console.Write("Please enter your password: ");
        string pass = Console.ReadLine()!;
        int i = 0;
        while(Password != pass && i < 3)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[Warning]\nYour password is incorrect!\nTry again: ");
            Console.ResetColor();
            pass = Console.ReadLine()!;
            i++;
        }
        if(i == 3)
        {
            return false;
        }
        else
            return true;
    }
    public void ShowProfile()
    {
        Console.Clear();
        Console.WriteLine("\n\t\tUser Profile");
        Console.WriteLine("==================================================");
        Console.WriteLine($"Full name\t\t{full_name}\nCard number\t\t{card_number}\nPhone number\t\t{tel}");
    }
}