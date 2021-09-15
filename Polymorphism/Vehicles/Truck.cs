using System;

namespace Vehicles
{
    class Truck : Vehicle
    {
        public override void Refuel(double quantity)
        {
            double fuelToAdd = quantity *0.95;
            this.FuelQuantity += fuelToAdd;

            Console.WriteLine($"Truck: {this.FuelQuantity:f2}");
        }
        public override void DriveVehicle(double distance)
        {
            double neededFuel = FuelConsumption + (distance * (this.FuelConsumptionPerKm + 1.6));

            if (this.FuelQuantity - neededFuel >= 0)
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
            }
        }
    }
}
