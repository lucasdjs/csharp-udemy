﻿using System.Globalization;
using Exercicio_vetor;


Estudante[] vetor = new Estudante[10];

Console.Write("Quantos quartos serão alugados: ");
int numeroQuartos = int.Parse(Console.ReadLine());

for (int i = 1; i <= numeroQuartos; i++) {

    Console.WriteLine("Aluguel: #" + i);
    Console.Write("Nome:");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());
    vetor[quarto] = new Estudante { Nome = nome, Email = email };

}
Console.WriteLine("Quartos ocupados: ");

for (int i = 1; i < 10; i++) {
    if (vetor[i] !=null) {
        Console.WriteLine(i + ": " + vetor[i].Nome + "," + vetor[i].Email);
    }

}