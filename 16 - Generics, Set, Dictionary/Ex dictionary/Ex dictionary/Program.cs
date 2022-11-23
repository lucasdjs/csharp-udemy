string caminhoArquivo = "C:\\temp\\ex.txt";

try
{
    using (StreamReader sr = File.OpenText(caminhoArquivo))
    {
        Dictionary<string, int> eleicao = new Dictionary<string, int>();

        while (!sr.EndOfStream)//enquanto não chegar no fim do arquivo
        {
            string[] line = sr.ReadLine().Split(',');
            string nome = line[0];
            int voto = int.Parse(line[1]);


            if (eleicao.ContainsKey(nome))
            {
                eleicao[nome] += voto;
            }
            else
            {
                eleicao[nome] = voto;
            }

        }
        foreach (var item in eleicao)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }

}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}

