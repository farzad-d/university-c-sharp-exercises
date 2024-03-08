using System;

namespace PersonalData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console colors
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();

            // Show personal information
            Console.WriteLine("** ** ** ** ** ** ** ** ** ** ** ** **");
            Console.WriteLine();
            Console.WriteLine("   Name: Farzad");
            Console.WriteLine("   Family: Daneshpour");
            Console.WriteLine("   Birth: 14/7/1990");
            Console.WriteLine("   Job: Collage student");
            Console.WriteLine();
            Console.WriteLine("** ** ** ** ** ** ** ** ** ** ** ** **");

            // If Enter is pressed clear the console, then show the phone number
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("** ** ** ** ** ** ** ** ** ** ** ** **");
            Console.WriteLine();
            Console.WriteLine("   Phone number: 0916 066 1091");
            Console.WriteLine();
            Console.WriteLine("** ** ** ** ** ** ** ** ** ** ** ** **");
            Console.ReadLine();
        }
    }
}