using System;
using System.Globalization;

namespace URI_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novosalario, reajuste, percentual;
            
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(salario >=0 && salario<= 400.00) {

                novosalario = salario * 1.15;
                reajuste = novosalario - salario;
                percentual = 15;
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {

                novosalario = salario * 1.12;
                reajuste = novosalario - salario;
                percentual = 12;
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {

                novosalario = salario * 1.10;
                reajuste = novosalario - salario;
                percentual = 10;
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {

                novosalario = salario * 1.07;
                reajuste = novosalario - salario;
                percentual = 7;
            }
            else
            {
                novosalario = salario * 1.04;
                reajuste = novosalario - salario;
                percentual = 4;
            }

            Console.WriteLine("NOVO SALARIO: " + novosalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("REAJUSTE GANHO: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("EM PERCENTUAL: " + percentual.ToString("F2", CultureInfo.InvariantCulture)+"%");
        }
    }
}
