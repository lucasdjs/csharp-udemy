DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

DateTime d2 = d.AddHours(2);
DateTime d3 = d.AddMinutes(3);
DateTime d4 = d.AddMonths(1);
DateTime d5 = d.AddYears(1);
DateTime d6 = d.AddDays(5);

Console.WriteLine(d);
Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);
Console.WriteLine(d5);
Console.WriteLine(d6);

DateTime d7 = new DateTime(2020, 10, 18);
TimeSpan t = d7.Subtract(d);
Console.WriteLine(t);
