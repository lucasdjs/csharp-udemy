using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoProduto
{
    internal class Produto
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
        public void CadastrarProduto()
        {
            Console.WriteLine("Entre os dados do produto:");

            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            Console.Write("Preço: ");
            Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        }


        public void AdicionarProdutos(int qtd)
        {
            Quantidade = qtd + Quantidade;
            ValorTotalEmEstoque();

        }
        public void RemoverProdutos(int quantidadesRemovidas)
        {
            Quantidade = Quantidade - quantidadesRemovidas;
            ValorTotalEmEstoque();

        }
        //public void MostrarProduto()
        //{
        //    Console.WriteLine($"Dados do Produto: {Nome}, ${Preco.ToString("F2", CultureInfo.InvariantCulture)}, ${Quantidade} unidades, Total: ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");

        //}
        public void MostrarAtualizado()
        {
            Console.WriteLine($"Dados atualizado:{Nome}, ${Preco}, {Quantidade} unidades, Total: ${ValorTotalEmEstoque()}");

        }


    }
}
