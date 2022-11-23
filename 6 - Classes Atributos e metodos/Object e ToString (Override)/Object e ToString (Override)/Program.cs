using ProjetoProduto;
using System;
using System.Globalization;

Produto dados = new Produto();


Console.WriteLine("Entre os dados do produto:");

Console.Write("Nome: ");
dados.Nome = Console.ReadLine();

Console.Write("Preço: ");
dados.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade no estoque: ");
dados.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Dados do Produto:" + dados );