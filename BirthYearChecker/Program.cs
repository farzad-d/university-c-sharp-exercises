using System;

namespace BirthYearChecker
{
    internal class Program
    {
        // Calculate user birth year
        static int GetBirthYear(int age)
        {
            int current_year = 1401;
            int birth_year = current_year - age;
            return birth_year;
        }
        // Check if user birth date is before or after revolution
        static bool EventCheck(int birth_year)
        {
            bool before_rev = true;
            if(birth_year < 1357)
                before_rev = true;
            else if(birth_year > 1357)
                before_rev = false;
            else
                {
                Console.Write("Enter your birth month: ");
                int birth_month = int.Parse(Console.ReadLine()!);
                if(birth_month < 11)
                    before_rev = true;
                else if(birth_month > 11)
                    before_rev = false;
                else
                    {
                        Console.Write("Enter your birth day: ");
                        int birth_day = int.Parse(Console.ReadLine()!);
                        if(birth_day < 22)
                            before_rev = true;
                        else
                            before_rev = false;
                    }
                }
            return before_rev;
        }
        static void Main(string[] args)
        {
            // Get user age and use functions to display the result
            Console.Write("Enter your age: ");
            int user_age = int.Parse(Console.ReadLine()!);
            int user_birth_year = GetBirthYear(user_age);

            if(EventCheck(user_birth_year) == true)
                {Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Good for you! You were born before Iran Revolution.");}
            else
                {Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hmmm! Unfortunately You were born after Iran Revolution.");}
        }
    }
}
