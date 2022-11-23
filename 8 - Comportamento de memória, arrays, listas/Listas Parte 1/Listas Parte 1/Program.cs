using System.Collections.Generic;


List<string> list = new List<string>();
//criou uma lista vazia instanciada
//List<string> list2 = new List<string> { "Maria", "Alex" };

list.Add("Lucas");
list.Add("LucasJS");
list.Add("Alex");
list.Add("João");
list.Add("Kassia");
list.Add("Ana");
list.Insert(1, "Marco"); //especifica a posição que ira adicionar o string

foreach (string obj in list)
{
    Console.WriteLine(obj);
}
Console.WriteLine("List count: " + list.Count); //mostrar a quantidade de elementos na lista

string s1 = list.Find(x => x[0] =='A'); //procura na lista a função determinada, como no exemplo a primeira letra a da lista
Console.WriteLine("First 'A': " + s1);

//static bool Test(string s)
//{
//    return s[0] == 'A';
//} função para usar no find

string s2 = list.FindLast(x => x[0] =='A');
Console.WriteLine("Last 'A' "+ s2);

int pos1 = list.FindIndex(x => x[0] == 'A');
Console.WriteLine("First position 'A' " + pos1);

int pos2 = list.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("Last position 'A' " + pos2);

List<string> list2 = list.FindAll(x => x.Length == 5);

Console.WriteLine("------------------------------------");

foreach(string obj in list2)
{
    Console.WriteLine(obj);
}

//remover

list.Remove("Alex");
Console.WriteLine("------------------------------------");
foreach (string obj in list) {
    Console.WriteLine(obj);
}
//declarar a posição da remoção
list.RemoveAt(0);
Console.WriteLine("------------------------------------");
foreach (string obj in list)
{
    Console.WriteLine(obj);
}

//remover todos que começam com a
list.RemoveAll(x => x[0] == 'L');
Console.WriteLine("------------------------------------");
foreach (string obj in list)
{
    Console.WriteLine(obj);
}

//remover de uma faixa
list.RemoveRange(0,2); //a partir da posição 0 remover 2 elementos
Console.WriteLine("------------------------------------");
foreach (string obj in list)
{
    Console.WriteLine(obj);
}



