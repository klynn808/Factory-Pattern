namespace FactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of tires for the vehicle you want to create:");

            string input = Console.ReadLine();

            IVehicle vehicle;
            
            if (int.TryParse(input, out int tireCount))
            {
                vehicle = VehicleFactory.GetVehicle(tireCount);
            }
            else
            {
                vehicle = VehicleFactory.GetVehicle(input);
            }
            vehicle.Drive();
            Console.ReadLine();
        }
    }
}
