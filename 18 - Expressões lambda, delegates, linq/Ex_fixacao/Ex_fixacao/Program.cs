using Ex_fixacao.Entities;
using System.Globalization;

Console.Write("Enter full file path: ");
string file = Console.ReadLine();

List<Employee> list = new List<Employee>();

Console.Write("Enter salary: ");
double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

using (StreamReader sr = File.OpenText(file))
{
    while (!sr.EndOfStream)
    {
        string[] text = sr.ReadLine().Split(',');
        string name = text[0];
        string email = text[1];
        double price = double.Parse(text[2], CultureInfo.InvariantCulture);

        list.Add(new Employee(name, email, price));
    }
}

var valida1 = list.Where(x => x.Salary > salary).OrderBy(x => x.Email).Select(x => x.Email);
var som = list.Where(x => x.Name.StartsWith('M')).Sum(x => x.Salary);

Console.WriteLine();
Console.WriteLine("Email of people whose salary is more than 2000.00: ");

foreach (var emp in valida1)
{
    Console.WriteLine(emp);
}

Console.WriteLine();
Console.WriteLine("Sum of salary of people whose name starts with 'M': " + som.ToString("F2", CultureInfo.InvariantCulture));

