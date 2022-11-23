FileStream fs = null;
try
{
    fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
    StreamReader sr = new StreamReader(fs);
    string line = sr.ReadLine();
    Console.WriteLine(line);
}
catch (FileNotFoundException e)
{
    Console.WriteLine("Deu ruim no arquivo !" + e.Message);
}
catch (DirectoryNotFoundException e) 
{
    Console.WriteLine("Deu ruim na pasta! " + e.Message);
}
finally
{
    if (fs != null)
    {
        fs.Close();
    }
}