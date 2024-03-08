using System;

namespace GradesReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get data from user
            short i = 0;
            short num_of_lessons = 0;

            Console.Write("How many lessons do you have? ");
            num_of_lessons = short.Parse(Console.ReadLine()!);

            string[] lessons = new string[num_of_lessons];
            float[] grades = new float[num_of_lessons];

            while(i<=num_of_lessons-1)
            {
                Console.Write($"Enter the lesson {i+1} name: ");
                string current_lesson = Console.ReadLine()!;
                lessons[i] = current_lesson;

                Console.Write($"Enter the {current_lesson} grade: ");
                grades[i] = float.Parse(Console.ReadLine()!);

                i++;
            }

            // Display the lessons and grades in two columns
            float grades_sum = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("- - - - - - - - - - - -\nLessons\t\tGrades\n- - - - - - - - - - - -");

            for(int j=0; j<=num_of_lessons-1; j++)
            {
                Console.WriteLine($"{lessons[j]}\t\t{grades[j]}");
                grades_sum += grades[j];
            }

            // Calculate and display the values of sum and avg
            float grades_avg = (float)Math.Round(grades_sum / num_of_lessons, 2);
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Sum\t\t{grades_sum}\nAvg\t\t{grades_avg}");

        }
    }
}
