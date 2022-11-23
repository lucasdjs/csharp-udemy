using EX_01;
using System.Globalization;

Retangulo retangulo = new Retangulo();

Console.WriteLine("Entre a largura e altura do retângulo: ");
Console.Write("Largura: ");
retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Altura: ");
retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();
Console.WriteLine(retangulo);
