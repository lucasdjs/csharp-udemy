using System.Globalization;

string [] vet = Console.ReadLine().Split(' ');
double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

double areatriangulo = a * c / 2;
double areacirculo = 3.14159 * (c * c);
double areatrap = (a + b) / 2 * c;
double areaquad = b * b;
double areareta = a * b;

Console.WriteLine("TRIANGULO: "+ areatriangulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("CIRCULO: " + areacirculo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPEZIO: " + areatrap.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO: " + areaquad.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("RETANGULO: " + areareta.ToString("F3", CultureInfo.InvariantCulture));