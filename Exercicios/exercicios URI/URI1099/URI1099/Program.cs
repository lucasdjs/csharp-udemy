using System;

namespace URI1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x,y;

            n = int.Parse(Console.ReadLine());

            string[] vet;
            vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);


            for (int i = 0; i < n; i++)
                if (x%2 !=0 && y % 2 != 0)
            {
                
                {
                    Console.WriteLine(x);
                    Console.WriteLine(y);
                
                }

            }


        }
    }
}
