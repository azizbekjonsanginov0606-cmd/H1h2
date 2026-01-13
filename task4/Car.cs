namespace task4;

public class Car
{
public string Make ; 

public string Model ; 

public int Year ; 

public double Mileage ; 

public double Fuel ; 

public void Drive(double miles)
    {
        double fuelNeeded = miles / 20;

        if (Fuel > fuelNeeded)
        {
            Console.WriteLine("Not enough fuel. Please refuel before driving.");
        }
        else
        {
            Mileage += miles;
            if (Fuel!=0)
            {
               Fuel -= fuelNeeded;  
            }else
            {
                Fuel=fuelNeeded;
            }

            Console.WriteLine(
                $"You have driven {miles} miles. Current mileage: {Mileage} miles. Remaining fuel: {Fuel} gallons.");
        }
    }

    // Add fuel method
    public void AddFuel(double gallons)
    {
        Fuel += gallons;
        Console.WriteLine(
            $"Added {gallons} gallons of fuel. Current fuel level: {Fuel} gallons.");
    }
}
