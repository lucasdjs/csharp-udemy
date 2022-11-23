using System;

namespace URI_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, resto, ano = 365, mes =30, dias =30;

           idade = int.Parse(Console.ReadLine());

            Console.WriteLine(idade);

            resto = idade / ano;
            Console.WriteLine(resto + " ano(s)");
            resto = idade % ano;
            

            resto = resto / mes;
            Console.WriteLine(resto + " mes(es)");
            dias = resto % dias;
            Console.WriteLine(resto + " dia(s)");

            








        }
    }
}
