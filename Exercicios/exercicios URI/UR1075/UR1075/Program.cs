using System;

namespace UR1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for (int i=1; i < 10000; i++)
            {
              if(i%N ==2)
                {
                    int valor = i;
                    Console.WriteLine(valor);
                }
            }
        }
    }
}
