int n = int.Parse(Console.ReadLine());
int[,] matriz = new int[n, n];

for (int i = 0; i < n; i++) {//incrementa linha ate o n
    string[]values = Console.ReadLine().Split(' ');


    for (int j = 0; j < n; j++) {//colunas
        matriz[i,j] = int.Parse(values[j]);
    }

}

Console.WriteLine("Diagonal principal: ");
for (int i = 0; i < n; i++) {
    Console.Write(matriz[i,i]+ " ");
}
Console.WriteLine();

//contar negtiva
int count = 0;
for (int i = 0; i < n; i++)
{
    Console.WriteLine();
    for (int j = 0; j < n; j++)
    {
        Console.Write(matriz[i,j] + " ");
        if (matriz[i, j] <0) {
            count++;
        }
    }
    
}
Console.WriteLine();
Console.WriteLine("NEGATIVE NUMBER: " + count);


