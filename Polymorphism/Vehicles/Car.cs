using System;

namespace Vehicles
{
    class Car : Vehicle
    { 
        public override void Refuel(double quantity)
        {
            this.FuelQuantity += quantity;
            Console.WriteLine($"Car: {this.FuelQuantity:f2}");
        }

        public override void DriveVehicle(double distance)
        {
            double neededFuel = FuelConsumption + (distance * (this.FuelConsumptionPerKm + 0.9));

            if (this.FuelQuantity - neededFuel >= 0)
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Car needs refueling");
            }
        }
    }
}
