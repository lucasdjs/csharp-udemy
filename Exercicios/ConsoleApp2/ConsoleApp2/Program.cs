using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, notafinal;

            nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            notafinal = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = "+ notafinal.ToString("F2", CultureInfo.InvariantCulture));

            if (notafinal < 60)
            {
                Console.WriteLine("REPROVADO");
            }

            else Console.WriteLine("APROVADO");
        }
    }
}
