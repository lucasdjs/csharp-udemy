using System;

namespace URI_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');


            int a, b;
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);


            if (a % b  == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }
        }
    }
}
