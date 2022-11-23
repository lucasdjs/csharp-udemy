using System.Globalization;

//Console.WriteLine(DateTime.Now);
//Console.WriteLine(DateTime.Now.Ticks);

//DateTime d1 = new DateTime(2022,07,29);
//Console.WriteLine(d1);
//DateTime d2 = new DateTime(2018,11,25, 20,45,03);
//Console.WriteLine(d2);
//DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03, 500);
//Console.WriteLine(d3);

//DateTime d4 =  DateTime.Now;
//DateTime d5 = DateTime.Today;
//Console.WriteLine(d5);
//DateTime d6 = DateTime.UtcNow;
//Console.WriteLine(d6);

//DateTime d1 = DateTime.Parse("2000-08-15");
//Console.WriteLine(d1);
//DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
//Console.WriteLine(d2);
//DateTime d3 = DateTime.Parse("23/05/1998");
//Console.WriteLine(d3);

//Console.WriteLine("data: ");
//string d4 = Console.ReadLine();
//Console.WriteLine(d3.ToString("dd/MM/yyyy"));

DateTime s2 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture) ;

Console.WriteLine(s2);