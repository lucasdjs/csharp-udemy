using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EX_03
{
    class Aluno
    {
        public double Nota1, Nota2, Nota3;
        public string Nome;

        public double SomaNotas()
        {
            return Nota1 + Nota2 + Nota3;
        }
       
        public void Resultado()
        {
            if (SomaNotas() >= 60.0)
            {
                Console.WriteLine("NOTA FINAL = " + SomaNotas().ToString("F2", CultureInfo.InvariantCulture));
                 Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + SomaNotas().ToString("F2", CultureInfo.InvariantCulture));
                double faltou = 60.00 - SomaNotas();
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + faltou.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS" );

            }
        }
      
    }
}
