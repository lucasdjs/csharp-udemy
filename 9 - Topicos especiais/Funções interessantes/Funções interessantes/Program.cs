string original = "abcde FGHIJ ABC abc DEFG   -";
//CONVERTER TUDO PRA MAIUSCULO
Console.WriteLine(original.ToUpper());
//CONVERTER TUDO PRA MINUSCULO
Console.WriteLine(original.ToLower());
//apaga espaço
string s3 = original.Trim();
Console.WriteLine("Trim: -" + s3 + "-");
// função de procura primeira ocorrencia
int n1 = original.IndexOf("bc");
Console.WriteLine(n1);
// função de procura ultima ocorrencia
int n2 = original.LastIndexOf("bc");
Console.WriteLine(n2);
//recortar string 
string s4 = original.Substring(3);
Console.WriteLine(s4);
string s5 = original.Substring(3,5);
Console.WriteLine(s5);
//trocar string 
string s6 = original.Replace('a', 'x');
Console.WriteLine(s6);
string s7 = original.Replace("abc", "xy");
Console.WriteLine(s7);
//verificar string vazia
bool b1 = String.IsNullOrEmpty(original);
Console.WriteLine(b1);
//verificar string vazia ou espaço em branco
bool b2 = String.IsNullOrWhiteSpace(original);
Console.WriteLine(b2);