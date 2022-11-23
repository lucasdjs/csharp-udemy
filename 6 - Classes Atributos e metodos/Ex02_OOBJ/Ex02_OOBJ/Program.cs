using Ex02_OOBJ;
using System.Globalization;

Funcionario funcionarioA = new Funcionario();
Funcionario funcionarioB = new Funcionario();

Console.WriteLine("Dados do primeiro funcionario: ");

Console.Write("Nome: ");
funcionarioA.Nome = Console.ReadLine();
Console.Write("Salário: ");
funcionarioA.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionario: ");
Console.Write("Nome: ");
funcionarioB.Nome = Console.ReadLine();
Console.Write("Sálario: ");
funcionarioB.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double salarioMedio = ((funcionarioA.Salario + funcionarioB.Salario) / 2);

Console.WriteLine("Salário médio: " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture)) ;