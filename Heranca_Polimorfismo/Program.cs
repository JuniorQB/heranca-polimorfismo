using Heranca_Polimorfismo.Entities;

class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        Console.Write("Enter the number of products: ");
        int quantityProducts = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantityProducts; i++)
        {
         

            Console.WriteLine($"Product #{i + 1}");

            Console.Write("Common, used or imported (c/u/i)? ");
            char option = char.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            if (option.Equals('i'))
            {
                Console.Write("Customs fee: ");
                double tax = double.Parse(Console.ReadLine());

                products.Add(new ImportedProduct(name, price, tax));

            }else if (option.Equals('u'))
            {
                Console.Write("Manufacture Date (DD/MM/YYYY): ");
                DateTime dateManufacture = DateTime.Parse(Console.ReadLine());
                products.Add(new UsedProduct(name, price, dateManufacture));
            } else
            {
                products.Add(new Product(name, price));
            }

        }

        Console.WriteLine("PRICE TAGS:");
        foreach (Product product in products)
        {
            Console.WriteLine(product.PriceTag());
        }
    }
}