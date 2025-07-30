namespace FactoryPattern;

public class Bike : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Riding on a bike.");
    }
}