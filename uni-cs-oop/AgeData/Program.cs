using System;

namespace AgeData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vars
            int birth_year;
            int current_age;
            
            //Input
            Console.WriteLine("Enter your birth year: ");
            birth_year=int.Parse(Console.ReadLine());
            
            // Calculate user age
            current_age=1401-birth_year;
            
            // Display the result
            if (current_age<12) 
            {
                Console.WriteLine("Child");
            } 
            else if (current_age>=12 && current_age<18) 
            {
                Console.WriteLine("Teenager");
            } 
            else if (current_age>=18 && current_age<40) 
            {
                Console.WriteLine("Young");
            } 
            else if (current_age>=40 && current_age<70) 
            {
                Console.WriteLine("Middle-aged");
            } 
            else if (current_age>=70 && current_age<=120) 
            {
                Console.WriteLine("Elder");
            } 
            else
            {
                Console.WriteLine("Error: Your birth year is not correct!");
            }
        }
    }
}