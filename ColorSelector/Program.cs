using System;

namespace ColorSelector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vars
            string name;
            char color;

            //Name input
            Console.WriteLine("Type your name: ");
            name=Console.ReadLine();

            // Color input
            Console.WriteLine("Select color: r(Red), b(Blue), m(Magenta)");
            color=char.Parse(Console.ReadLine());

            // Display the result
            if (color=='r')
            {
                Console.BackgroundColor=ConsoleColor.Red;
            }
            else if (color=='b')
            {
                Console.BackgroundColor=ConsoleColor.Blue;
            }
            else if (color=='m')
            {
                Console.BackgroundColor=ConsoleColor.Magenta;
            }
            else
            {
                Console.BackgroundColor=ConsoleColor.Yellow;
            }

            Console.Clear();
            Console.WriteLine(name);
        }
    }
}