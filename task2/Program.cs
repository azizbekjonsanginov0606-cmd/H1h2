// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using task2;

Rectangle rectangle=new();
Console.Write("width = ");
rectangle.Width= Convert.ToDouble(Console.ReadLine());
Console.Write("height = ");
rectangle.Height= Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Area = {rectangle.Area()}");

