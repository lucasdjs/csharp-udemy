using System.Globalization;

double area;
double x = 3.14159;
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
raio = raio * raio;

area = x * raio;

Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));