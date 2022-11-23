Dictionary<string, string> cookies =  new Dictionary<string, string>();

cookies["user"] = "maria";
cookies["user"] = "Lucas";
cookies["email"] = "maria@gmail.com";
cookies["email"] = "maria@gmail.com";
cookies["phone"] = "9984240024";
cookies["phone"] = "40028922";

Console.WriteLine(cookies["email"]);
Console.WriteLine(cookies["phone"]);

cookies.Remove("email");


if (cookies.ContainsKey("email"))
{
    Console.WriteLine(cookies["email"]);
}
else
{
    Console.WriteLine("There is no email key"!);
}

Console.WriteLine("Size : " + cookies.Count);

Console.WriteLine("ALL COOKIES : ");

foreach (KeyValuePair<string, string> item in cookies)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}