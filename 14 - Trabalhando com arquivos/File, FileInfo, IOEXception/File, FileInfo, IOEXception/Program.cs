using System.IO;

string sourcePath = @"c:\temp\file1.txt";

string targetPath = @"c:\temp\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);
    string[] lines= File.ReadAllLines(sourcePath);

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}

catch (IOException e)
{
    Console.WriteLine("An error occured");
    Console.WriteLine(e.Message);

}