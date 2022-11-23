using System;
using System.Globalization;

namespace vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];

            //leitura dos dados
            for(int i=0; i<N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                alturas[i] = double.Parse(s[2], CultureInfo.InvariantCulture );

            }
            //calculo da altura média das pessoas
            double soma = 0.0;
            for(int i = 0; i < N; i++)
            {
                soma = soma + alturas[i];
                
            }
            double media = soma / N;

            //pessoas com menor de 16 anos

            int pessoas=0;

            for(int i=0;i<N; i++) {
                if (idades[i] < 16) {
                    pessoas++;
                }
            }

            Double porcentagem;
            porcentagem = (double) pessoas / N * 100;

            Console.WriteLine("Altura média: " + media.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Pessoas menor de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture )+ "%");
        }
    }
}
