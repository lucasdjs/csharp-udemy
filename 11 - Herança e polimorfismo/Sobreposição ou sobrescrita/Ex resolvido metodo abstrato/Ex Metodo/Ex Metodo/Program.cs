using Ex_Metodo.Entities;
using Ex_Metodo.Entities.Enum;
using System.Globalization;

Console.Write("Enter the number of shapes: ");
int number  = int.Parse(Console.ReadLine());

List<Shape> list = new List<Shape>();

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"Shape #{i}: ");
    Console.Write("Rectangle or Circle (r/c)? ");

    char type = char.Parse(Console.ReadLine().ToLower());

    Console.Write("Color (BLACK/BLUE/RED): ");
    Color color = Enum.Parse<Color>(Console.ReadLine().ToUpper());

    if (type == 'r')
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Heigth: ");
        double height = double.Parse(Console.ReadLine());

        list.Add(new Rectangle(width, height, color));
    }
    else if (type == 'c')
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine());
        list.Add(new Circle(radius, color));
    }
    else {
        Console.WriteLine("Comando invalido");
        
    }

}
Console.WriteLine();
Console.WriteLine("SHAPE AREAS: ");

foreach (Shape item in list)
{
    Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
}