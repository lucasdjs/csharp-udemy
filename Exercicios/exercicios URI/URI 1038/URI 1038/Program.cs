using System;
using System.Globalization;

namespace URI_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, qtd;
            

            string[] vet = Console.ReadLine().Split(' ');

            cod = int.Parse(vet[0]);
            qtd = int.Parse(vet[1]);
            double total;
            if (cod == 1)
            {
                total = 4.00 * qtd;

            }
            else if (cod == 2)
            {
                total = 4.50 * qtd;

            }
            else if (cod == 3)
            {
                total = 5.00 * qtd;

            }

            else if (cod == 4)
            {
                total = 2.00 * qtd;

            }
            else 
            {
                total = 1.50 * qtd;


            }

            Console.WriteLine("Total = R$" + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
