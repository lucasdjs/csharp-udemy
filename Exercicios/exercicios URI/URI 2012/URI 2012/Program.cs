using System;
using System.Globalization;

namespace URI_2012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            double pi = 3.14159;
            double areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            

            areaTriangulo = (A * C)/2.0;
            areaCirculo = C* C * pi;
            areaTrapezio = (A + B) * C / 2;
            areaQuadrado = B*B;
            areaRetangulo = A * B;

            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
