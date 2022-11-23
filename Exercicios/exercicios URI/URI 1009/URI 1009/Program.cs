using System;
using System.Globalization;

namespace URI_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, totalvendas, totalreceber, comissao;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalvendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            comissao = totalvendas * 15 / 100;

            totalreceber = salario + comissao;

            Console.WriteLine("Total = R$ " + totalreceber.ToString("F2", CultureInfo.InvariantCulture));





            Console.ReadLine();
        }
    }
}
