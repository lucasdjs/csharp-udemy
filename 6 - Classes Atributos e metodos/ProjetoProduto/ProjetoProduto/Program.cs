using ProjetoProduto;
using System;
using System.Globalization;

Produto dados = new Produto();


dados.CadastrarProduto();
Console.WriteLine(dados);


Console.Write($"Digite o número de produtos a ser adicionado ao estoque: ");
int qtd = int.Parse(Console.ReadLine());
dados.AdicionarProdutos(qtd);
dados.MostrarAtualizado();

Console.Write($"Digite o número de produtos a ser removido do estoque: ");
int qtdRemover = int.Parse(Console.ReadLine());
dados.RemoverProdutos(qtdRemover);
dados.MostrarAtualizado();
