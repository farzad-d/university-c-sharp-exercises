using System;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inputs and Vars
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            String op = Console.ReadLine();

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Calculate and display the result
            if (op == "+")
                Console.WriteLine($"Result = {num1 + num2}");
            else if (op == "-")
                Console.WriteLine($"Result = {num1 - num2}");
            else if (op == "*")
                Console.WriteLine($"Result = {num1 * num2}");
            else if (op == "/")
                Console.WriteLine($"Result = {num1 / num2}");
            else if (op == "%")
                Console.WriteLine($"Result = {num1 % num2}");
            else
                Console.WriteLine("Invalid Operator!");
        }
    }
}
