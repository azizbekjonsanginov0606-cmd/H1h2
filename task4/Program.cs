// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using task4;
Car myCar = new Car();
myCar.Make="Toyota";
myCar.Model="Camry";
myCar.Year=2022;
myCar.Mileage=0;
myCar.Fuel=0;
Console.WriteLine($"Make: {myCar.Make}");
Console.WriteLine($"Model: {myCar.Model}");
Console.WriteLine($"Year: {myCar.Year}");
Console.WriteLine($"Mileage: {myCar.Mileage} miles");
Console.WriteLine($"Fuel level: {myCar.Fuel} gallons");

myCar.Drive(100);

myCar.AddFuel(10);

Console.WriteLine($"\nAfter the trip and refueling:");
Console.WriteLine($"Mileage: {myCar.Mileage} miles");
Console.WriteLine($"Fuel level: {myCar.Fuel} gallons");
