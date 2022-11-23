TimeSpan t = new TimeSpan (1, 30,10);
Console.WriteLine(t);

Console.WriteLine("Days:" + t.Days);
Console.WriteLine("Hours:" + t.Hours);
Console.WriteLine("Minutes:" + t.Minutes);
Console.WriteLine("Miliseconds:" + t.Milliseconds);
Console.WriteLine("Seconds:" + t.Seconds);
Console.WriteLine("Ticks:" + t.Ticks);
Console.WriteLine("TotalDays:" + t.TotalDays);
Console.WriteLine("TotalHours:" + t.TotalHours);
Console.WriteLine("TotalMinutes:" + t.TotalMinutes);
Console.WriteLine("TotalSeconds:" + t.TotalSeconds);
Console.WriteLine("TotalMilliseconds:" + t.TotalMilliseconds);


Console.WriteLine("---------------------------");
Console.WriteLine("Operações: ");

TimeSpan t2 = new TimeSpan(0, 10, 5);
TimeSpan sum = t.Add(t2);
Console.WriteLine(sum);
TimeSpan dif = t.Subtract(t2);
Console.WriteLine(dif);
TimeSpan mult = t2.Multiply(2.0);
Console.WriteLine(mult);
