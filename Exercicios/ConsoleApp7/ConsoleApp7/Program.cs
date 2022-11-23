using System;
using System.Globalization;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, media;
            int cont;
            x = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            double soma = 0.0;
            cont = 0;
            

            while (x > 0)
            {
                x = int.Parse(Console.ReadLine());
                cont = cont + 1;
                soma = soma + x;
                x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            if (cont == 0)
            {

                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                media = soma / cont;

                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
