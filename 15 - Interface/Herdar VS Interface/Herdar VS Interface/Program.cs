
using Herdar_VS_Interface.Model.Entities;
using Herdar_VS_Interface.Model.Entities.Interface;
using Herdar_VS_Interface.Model.Enums;

IShape s1 = new Circle() { Radius = 2.00, Color = Color.White };
IShape s2 = new Retangle() { Width = 3.5, Heigth = 4.2, Color = Color.Black };

Console.WriteLine(s1);
Console.WriteLine(s2);