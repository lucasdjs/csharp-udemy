using Generics.Entities;
using Generics.Services;

PrintService<string> printService = new PrintService<string>();
PrintService<int> printServices = new PrintService<int>();

Console.Write("How many values: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++) { 
    string x = Console.ReadLine();
    printService.AddValue(x);
}

for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    printServices.AddValue(x);
}

printService.Print();
Console.WriteLine();
Console.WriteLine("First: " + printService.First());

