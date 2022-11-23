using EX_resolvido.Entities;
using System.IO;


HashSet<LogRecord> set = new HashSet<LogRecord>();


Console.Write("Enter file full path: "); //digita o nome do arquivo

string path = Console.ReadLine();

try
{
    using (StreamReader sr = File.OpenText(path)) //abrir o arquivo
    {
        while (!sr.EndOfStream)//enquanto não chegar no fim do arquivo
        {

            string[] line = sr.ReadLine().Split(' ');//leia uma linha e salva na variavel
            string name = line[0];
            DateTime instant = DateTime.Parse(line[1]);
            set.Add(new LogRecord {Username = name, Instant = instant});

        }

        Console.WriteLine("Total users: " + set.Count);
    }
}
catch(IOException e)
{
    Console.WriteLine(e.Message);
}