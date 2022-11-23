using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EX_01
{
     class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
         return Largura * Altura;
        }
        public double Perimetro()
        {
         return (Largura+Altura)*2;
        }

        public double Diagonal()
        {
            double c= (Math.Pow(Largura,2)) + (Math.Pow(Altura,2));
            return Math.Sqrt(c) ;
        }

        public override string ToString()
        {
            return $"AREA = {Area().ToString("F2",CultureInfo.InvariantCulture)} \n" +
             $"PERIMETRO = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\n"+
             $"DIAGONAL = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }


    }
}
