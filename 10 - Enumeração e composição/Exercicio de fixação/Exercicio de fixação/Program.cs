using Exercicio_de_fixação.Entities;
using Exercicio_de_fixação.Entities.Enums;

Console.WriteLine("Enter cliente data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth Date (DD/MM/YYYY): ");

DateTime date = DateTime.Parse(Console.ReadLine()); Console.WriteLine("Enter order Data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());


Client client = new Client(name,email,date);
Order order = new Order(status, client);


Console.Write("How many items to this order: ");
int n = int.Parse(Console.ReadLine());


for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter #{i+1} item data: ");
    Console.Write("Product Name: ");
    string nameProduct = Console.ReadLine();
    Console.Write("Product Price: ");
    double price = double.Parse(Console.ReadLine());
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());
    
    
    Product product = new Product(nameProduct, price);
    OrderItem orderItem = new OrderItem(price, quantity, product);

   order.AddItem(orderItem);

    
}


Console.WriteLine();
Console.WriteLine(order);
