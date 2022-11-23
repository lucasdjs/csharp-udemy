using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devinhouse_POO.Models
{
    internal class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto { get; set; }

        public override void Pagar(decimal valor)
        {
            if (DataVenciment < DateTime.Now)
            {
                Console.WriteLine("Não é possivel pagar um boleto vencido");
            }
            else {
                base.Pagar(valor);
            }


        }
    }


}
