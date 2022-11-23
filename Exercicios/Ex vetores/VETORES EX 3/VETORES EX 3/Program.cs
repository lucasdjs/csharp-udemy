using System;

namespace VETORES_EX_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] vet1 = new int[N];
            int[] vet2 = new int[N];
            

            string[] vetA = (Console.ReadLine().Split(' '));
            string[] vetB = (Console.ReadLine().Split(' '));
            

            for (int i = 0; i<N; i++)
            {
                vet1[i] = int.Parse(vetA[i]);
                vet2[i] = int.Parse(vetB[i]);

            }

            int[] vet3 = new int[N];

            for (int i = 0; i < N; i++)
            {
                vet3[i] = vet1[i] + vet2[i]; 
                    
             }

            for (int i = 0; i < N; i++) {
                
                Console.Write(vet3[i] + " ") ;
            }

            


        }
    }
}
