using Ex_2_Vetores;
using System.Globalization;

int n = int.Parse(Console.ReadLine());

Produto[] vetor = new Produto[n];

for (int i = 0; i < n; i++) { 
    string nome = Console.ReadLine();
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    vetor[i] = new Produto { Nome = nome, Price = price };

}

double soma = 0.00;

for (int i = 0; i < n; i++) {
    soma += vetor[i].Price;
}

double media = soma / n;

Console.WriteLine("Preço medio = " + media.ToString("F2", CultureInfo.InvariantCulture));