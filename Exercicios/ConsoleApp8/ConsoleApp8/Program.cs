using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha, x;


            x = int.Parse(Console.ReadLine());

            senha = 2002;

            while (x != senha)
            {
               
                Console.WriteLine("Senha Invalida");
                x = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Acesso Permitido");

            Console.ReadLine();

        }
    }
}
