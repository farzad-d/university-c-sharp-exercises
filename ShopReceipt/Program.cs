using System;

namespace MyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the number of products
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("How many products do have? ");
            short products_num = short.Parse(Console.ReadLine()!);
            Console.WriteLine();
            Product[] products_list = new Product[products_num];

            // Get products information
            for(int i = 0; i < products_num; i++)
            {
            Console.Write($"What's the product {i+1} name? ");
            string pr_name = Console.ReadLine()!;

            Console.Write($"How many grams is the {pr_name}? ");
            float pr_weight = float.Parse(Console.ReadLine()!);
            
            Console.Write($"How much does the {pr_name} cost? ");
            double pr_price = double.Parse(Console.ReadLine()!);

            Console.Write($"Enter the {pr_name} barcode: ");
            long pr_barcode = long.Parse(Console.ReadLine()!);

            Product initial_receipt = new Product(pr_name, pr_weight, pr_price, pr_barcode);                    
            products_list[i] = initial_receipt;

            // Calculate the discount for each product
            Console.Write("How much is the discount? ");
            double discount_amount = double.Parse(Console.ReadLine()!);
            products_list[i].final_price = products_list[i].ApplyDiscount(discount_amount);
            Console.WriteLine();
            }

            // Show all products information
            double total_price = 0;
            for(int j = 0; j < products_num; j++)
            {
                products_list[j].ProductInfo();
                total_price += products_list[j].final_price;
            }

            // Show the total price of all products
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Total price of all products = {total_price} $");
        }
    }
}