using Exercicio_fixacao.Entities;
using System.Globalization;

List<TaxPlayer> list = new List<TaxPlayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data: ");
    Console.Write("Individual or company (i/c): ");
    char type = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double anual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (type == 'i')
    {
        Console.Write("Health expenditures: ");
        double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Individual(health, name, anual));

    }
    else {
        Console.Write("Number of employees: ");
        int employees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Company(employees, name, anual));
    }

}
double total = 0.00;

Console.WriteLine();
Console.WriteLine("TAXES PAID:");
Console.WriteLine();
foreach (TaxPlayer player in list)
{
    Console.WriteLine(player.Name + " $ " + player.Tax().ToString("F2", CultureInfo.InvariantCulture));
    total += player.Tax();
}


Console.WriteLine();
Console.Write($"TOTAL TAXES: $ {total.ToString("F2", CultureInfo.InvariantCulture)} ");