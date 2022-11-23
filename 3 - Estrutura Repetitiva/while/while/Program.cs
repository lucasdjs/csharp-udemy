using System.Globalization;

Console.Write("Digite um numero: ");
double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



while (numero > 0)
{
    
    double raiz = Math.Sqrt(numero);
    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
    Console.Write("Digite um numero: ");
    numero = int.Parse(Console.ReadLine());

}

Console.WriteLine("Numero negativo!");
