using Devinhouse_POO.Models;

var pagamento = new Pagamento();
Console.WriteLine(pagamento.Descricao);

var boleto = new PagamentoBoleto();
boleto.DataVenciment = new DateTime(2022, 06, 14);
boleto.Pagar(100.00M);

var boleto2 = new PagamentoBoleto();
boleto2.DataVenciment = new DateTime(2022, 06, 20);
boleto2.Pagar(100.00M);

var pix = new PagamentoPix();
pix.DataVenciment = new DateTime(2022, 06, 10);
pix.Pagar(49.99M);
