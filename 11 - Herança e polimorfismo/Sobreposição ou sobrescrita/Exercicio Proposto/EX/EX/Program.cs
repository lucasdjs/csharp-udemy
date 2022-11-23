using EX.Entities;
using System.Globalization;

Console.Write("Enter the number of products: ");
int numberProduct = int.Parse(Console.ReadLine());


List<Product> list = new List<Product>();


for (int i = 0; i < numberProduct; i++)
{
    Console.WriteLine($"Product #{i+1} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char typeProduct = char.Parse(Console.ReadLine());


    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



    if (typeProduct == 'i')
    {
        Console.Write("Custom fee: ");
        double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new ImportedProduct(name, price, customFee));
    }
    else if (typeProduct == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(name, price, date));
    }
    else {
        list.Add(new Product(name, price));
    }

  

}
Console.WriteLine();
Console.WriteLine("PRICE TAGS: ");
Console.WriteLine();

foreach (Product product in list) {
    Console.WriteLine(product.PriceTag());
}