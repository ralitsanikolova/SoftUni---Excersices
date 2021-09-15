using System;

namespace Vehicles_Extension
{
    class Truck : Vehicle
    {
        public override void Refuel(double quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            else if (this.FuelQuantity + quantity > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {quantity} fuel in the tank");
            }

            this.FuelQuantity += quantity;
            Console.WriteLine($"Car: {this.FuelQuantity:f2}");
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
