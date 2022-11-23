

string path = @"c:\temp\file1.txt";

StreamReader sr = null;

try
{
    sr = File.OpenText(path);

    while(!sr.EndOfStream)
    {
        string lines = sr.ReadLine();
        Console.WriteLine(lines);
    }
    string line = sr.ReadLine();

    Console.WriteLine(line);
}
catch (IOException e)
{

    Console.WriteLine("An error accured");
    Console.WriteLine(e.Message);
}

finally
{
    if(sr!=null) sr.Close();
}