using System;
using System.Globalization;

namespace URI_10015
{
    class Program
    {
        static void Main(string[] args)
        {
           double distancia;

            string [] vet = Console.ReadLine().Split(' ');
            

           double x1 = double.Parse(vet[0],CultureInfo.InvariantCulture);
            double y1 = double.Parse(vet[1],CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');

            double x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));





        }
    }
}
