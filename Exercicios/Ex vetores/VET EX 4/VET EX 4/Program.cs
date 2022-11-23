using System;
using System.Globalization;

namespace VET_EX_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()) ;

            double[] vet = new double [N];

            string[] numeros = Console.ReadLine().Split(' ');
            

            //inserir numeros no vetor vet
            for (int i = 0; i<N; i++)
            {
                vet[i] =Double.Parse(numeros[i], CultureInfo.InvariantCulture);
            }

            //mostrar numeros no vetor vet

            double soma = 0.00;
            double media = 0.00;
            

            for (int i = 0; i < N; i++)
            {
                
                soma = vet[i] + soma;
                
                media = soma / N;

                

            }

            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));


            for (int i = 0; i < N; i++)
            if (vet[i] < media)
            {

                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));                   

                }



            
            


        }
    }
}
