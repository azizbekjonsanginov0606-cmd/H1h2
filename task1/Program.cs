// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using task1;

Person Umed = new();
Umed.FirstName = "Umed";
Umed.LastName = "Safarov";
Umed.Age = 20;
Console.WriteLine(Umed.GetFullName());
Console.WriteLine("My birth year is " + Umed.GetBirthYear());
