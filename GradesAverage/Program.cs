using System;

namespace GradesAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sum of grades
            double totalGrades = 0;

            // Adding the grades
            for(int i = 0; i < 4; i++)
            {
                Console.Write($"{i+1}.Enter the grade: ");
                totalGrades += Convert.ToDouble(Console.ReadLine());
            }
            // Display the result
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The average of grades is: {totalGrades / 4}");
        }
    }
}