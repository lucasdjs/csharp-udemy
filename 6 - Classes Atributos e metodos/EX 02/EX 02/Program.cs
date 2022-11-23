using System;
using System.Globalization;
namespace EX_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {funcionario.Nome} , $ {funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double aumentoSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(aumentoSalario);

            Console.WriteLine($"Dados atualizados: {funcionario.Nome} $ {funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");



        }
    }
}
