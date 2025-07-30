using System.Net.WebSockets;

namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle BuildVehicle(string vehicleType)
    {
        switch (vehicleType.ToLower())
        {
            case "4":
                return new Car();
            case "four":
                return new Car();
            case "2":
                return new Bike();
            case "two":
                return new Bike();
            default:
                return new Car();
            
        }
    }
}