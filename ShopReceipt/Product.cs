    class Product
    {
        public string name;
        public float weight;
        public double price;
        public long barcode;
        public double final_price;

        // Constructor for getting arguments from user
        public Product(string aName, float aWeight, double aPrice, long aBarcode)
        {
            name = aName;
            weight = aWeight;
            price = aPrice;
            barcode = aBarcode;
        }

        // This method calculates discount for each product
        public double ApplyDiscount(double discount)
        {
            return price - (price * (discount / 100));
        }

        // This method displays each product information
        public void ProductInfo()
        {
            if(final_price > 1_000_000)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Product: {name}\nWeight: {weight} g\nFinal price: {final_price} $\nBarcode: {barcode}");
            Console.WriteLine("=========================");
        }
    }