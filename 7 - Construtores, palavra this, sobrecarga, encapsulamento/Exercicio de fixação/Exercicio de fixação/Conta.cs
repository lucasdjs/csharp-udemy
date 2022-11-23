using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_de_fixação
{
    internal class Conta
    {   //atributos privados

        public double Saldo { get; private set; }
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
   

        //Construtores
        public Conta(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            
        }                                                           
        public Conta(int numeroConta, string nomeTitular, double saldo) : this(numeroConta, nomeTitular)
        {
            Saldo = saldo;
        }

        //Propriedades customizadas


        public void Depositar(double valor)
        {
           Saldo= Saldo + valor;
        }
        public void Sacar(double valor)
        {
            Saldo = Saldo - valor - 5.00;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {NomeTitular}, Saldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}\n";
        }

    }
        
}
