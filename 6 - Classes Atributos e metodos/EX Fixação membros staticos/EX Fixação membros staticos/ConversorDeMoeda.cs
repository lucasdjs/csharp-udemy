using System;
using System.Collections.Generic;
using System.Text;

namespace EX_Fixação_membros_staticos
{
    class ConversorDeMoeda
    {
        public static double IOF;

      
        public static double ValorPago(double valor, double cotacao){
           
            double totalReais = cotacao * valor;
            return totalReais + totalReais * 6.00 / 100.00;


        }


    }
}
