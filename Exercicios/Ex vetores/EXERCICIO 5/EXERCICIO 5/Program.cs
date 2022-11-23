using System;
using System.Globalization;

namespace EXERCICIO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];
            

            string[] valores = (Console.ReadLine().Split(' '));

           
            for(int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(valores[i]);
               
            }

            double somaDosPares = 0.0;
            int quantidadeDePares = 0;

            for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    somaDosPares = somaDosPares + vet[i];
                    quantidadeDePares++;
                }
            }

            double media = 0.00;

            media = somaDosPares / quantidadeDePares;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture ));










        }
    }
}
