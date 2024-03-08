using System;

namespace Divisibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Getting numbers from the user
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Calculate and display the result
            for(int i = num1; i<num2; i++)
            {
                // if(i%3==0 || i%7==0)
                if(i%3==0 && i%7==0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                }
            }
        }
    }
}