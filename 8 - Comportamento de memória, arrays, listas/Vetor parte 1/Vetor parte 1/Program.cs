using System.Globalization;

int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double[] vect = new double[n];


for (int i = 0; i < n; i++)
{
    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
   
}
double soma = 0.00;

foreach (int i in vect)
{
    Console.WriteLine("voce digitou: "+ i.ToString("F2", CultureInfo.InvariantCulture));

}


for (int i = 0; i < n; i++) {
    soma += vect[i];

}

double media = soma / n;


Console.WriteLine("Soma: "+ soma.ToString("F2",CultureInfo.InvariantCulture) + " Media: " + media.ToString("F2",CultureInfo.InvariantCulture));



