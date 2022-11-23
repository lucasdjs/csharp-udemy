using System;
using System.Globalization;

namespace URI_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double volume;
            double raio;
            double x = 3;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            raio = Math.Pow(raio, x);

            volume = (4 / 3.0) * pi * raio;

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
