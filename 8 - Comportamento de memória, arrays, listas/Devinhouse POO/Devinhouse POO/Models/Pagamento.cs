using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devinhouse_POO.Models
{
    internal class Pagamento
    {
        public Guid Id { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataVenciment{get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }

        public virtual void Pagar(decimal valor) {

            Console.WriteLine("Método pagar no pagamento");
            Valor = valor;
            DataPagamento = DateTime.Now;
        
        }
    }
}
