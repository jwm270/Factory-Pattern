namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels do you have? (2 or 4)");
                var input = Console.ReadLine();
                
                var wheels = VehicleFactory.BuildVehicle(input);
                
                wheels.Drive();
                
        }
    }
}
