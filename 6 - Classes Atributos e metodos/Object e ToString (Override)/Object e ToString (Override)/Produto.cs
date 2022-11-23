using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoProduto
    {
         class Produto
        {
            public string Nome;
            public double Preco;
            public int Quantidade;


            public double ValorTotalEmEstoque()
            {
                return Preco * Quantidade;
            }

            public override string ToString()
            {
             return $"Dados do Produto:{Nome}, ${Preco}, {Quantidade} unidades, Total: ${ValorTotalEmEstoque()}";
            }




        }

}

