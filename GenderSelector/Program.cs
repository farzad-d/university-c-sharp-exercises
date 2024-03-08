using System;

namespace GenderSelector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gender;
            Console.WriteLine("Are you female? true/false");
            gender=bool.Parse(Console.ReadLine());
            
            if (gender==true)
            {
                Console.WriteLine("You are female");
            }
            else
            {
                Console.WriteLine("You are male");
            }
        }
    }
}