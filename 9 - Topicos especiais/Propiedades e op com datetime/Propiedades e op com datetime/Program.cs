DateTime d = new DateTime(2022, 08, 03, 13, 45, 58, 275);


Console.WriteLine(d);
Console.WriteLine("1 - Date: " + d.Date); //data completa sem as horas
Console.WriteLine("2 - Day: " + d.Day); //dia
Console.WriteLine("3 - DayOFWeek: " + d.DayOfWeek); // dia da semana
Console.WriteLine("4 - DayOffYear: " + d.DayOfYear); // dia do ano
Console.WriteLine("5 - horas: " + d.Hour); // hora
Console.WriteLine("5 - Milisecond: " + d.Millisecond); //milisegundo
Console.WriteLine("5 - Kind: " + d.Kind); // Tipo local ou universal
Console.WriteLine("6 - Minute: " + d.Minute); //minuto
Console.WriteLine("7 - segundos: " + d.Second); // segundo
Console.WriteLine("8 - Ticks: " + d.Ticks); //quantidade de ticks
Console.WriteLine("9 - TimeOfDay: " + d.TimeOfDay);//hora
Console.WriteLine("10 - year: " + d.Year); //ano


//---------------------------------------------------
Console.WriteLine(d.ToLongDateString());
Console.WriteLine(d.ToLongTimeString()); //imprime o horario
Console.WriteLine(d.ToShortDateString()); //data em formato resumido
Console.WriteLine(d.ToShortTimeString()); //hora e minuto
Console.WriteLine(d.ToString());

string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
Console.WriteLine(s6);
string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.FFF");
Console.WriteLine(s7);