using System.Globalization;

double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double desconto  = (preco<20.00) ? preco * 0.1 : preco * 0.05;

/*seria mesma coisa que :

if(preco<20.0){
desconto = preco * 0.1;
}
else
{
desconto = preco * 0.5;
}

*/

Console.WriteLine(desconto);
