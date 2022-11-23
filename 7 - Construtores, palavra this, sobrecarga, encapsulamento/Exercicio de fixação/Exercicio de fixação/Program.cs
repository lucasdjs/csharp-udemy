using Exercicio_de_fixação;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (S/N)?");
            char resposta = char.Parse(Console.ReadLine());
            double saldo = 0;

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre com o valor inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular, saldo);

            }
            else {
                conta = new Conta(numero, titular);
            }
            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(conta);


            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(deposito);
            Console.WriteLine("Dados da conta atualizado:");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(saque);
            Console.WriteLine("Dados da conta atualizado:");
            Console.WriteLine(conta);


        }
    }
}



