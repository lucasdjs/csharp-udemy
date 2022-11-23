using System;
using System.Collections.Generic;
using System.Text;

namespace EX_02
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.00);
         
        }
        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

    }
}
