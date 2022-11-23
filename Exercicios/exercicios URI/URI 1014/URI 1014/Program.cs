using System;
using System.Globalization;

namespace URI_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double combustivel, total;

            distancia = int.Parse(Console.ReadLine());
           combustivel = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture) ;

            total = distancia / combustivel;

            Console.WriteLine(total.ToString("N3") + " km/l" , CultureInfo.InvariantCulture);


        }
    }
}
