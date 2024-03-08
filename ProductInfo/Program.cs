namespace ProductInfo
{
    class program {         
        static void Main(string[] args)
        {
            // Variables
            string name;
            float weight;
            int price;
            bool type;

            // Inputs
            Console.WriteLine("Enter the product name: ");
            name=Console.ReadLine();
            Console.WriteLine("Enter the product weight: ");
            weight=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of the product: ");
            price=int.Parse(Console.ReadLine());
            Console.WriteLine("Is that fragile? True/False");
            type=bool.Parse(Console.ReadLine());

            // Color scheme
            Console.BackgroundColor=ConsoleColor.DarkBlue;
            Console.ForegroundColor=ConsoleColor.White;
            Console.Clear();

            // Outputs
            Console.WriteLine("\n** ** ** ** ** ** ** ** ** ** ** ** ** ** **\n");
            Console.WriteLine("  Product name: " + name);
            Console.WriteLine("  Product weight: " + weight + "kg");
            Console.WriteLine("  Price: " + price + "$");
            Console.WriteLine("  Fragile: " + type);
            Console.WriteLine("\n** ** ** ** ** ** ** ** ** ** ** ** ** ** **\n");

        }
    }
}