{
Console.WriteLine("Digite tres numeros: ");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());


double resultado = Maior(n1, n2, n3);

Console.WriteLine("Maior = " + resultado);


}


static int Maior(int a, int b, int c)
{
    int M;
    if (a > b && a > c)
    {
        M = a;

    }
    else if (b > c)
    {
        M = b;
    }
    else
    {
        M = c;
    }
    return M;

}