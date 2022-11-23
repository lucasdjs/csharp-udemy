using System.Globalization;

int numero = int.Parse(Console.ReadLine());
double horas = double.Parse(Console.ReadLine());
double valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double salario = horas * valorhora;
Console.WriteLine("NUMBER = " + numero);
Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));



























