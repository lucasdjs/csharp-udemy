using System;
using System.Globalization;

namespace EX_Fixação_membros_staticos
{
    class Program
    {
        static void Main(string[] args)
        {
        

            Console.Write("Qual é a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar?");
            double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em reais: {ConversorDeMoeda.ValorPago(compra, cotacao).ToString("F2", CultureInfo.InvariantCulture)}");

            

            

        }
    }
}
