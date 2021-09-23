using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_Extension
{
    class Bus : Vehicle
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
            double neededFuel = FuelConsumption + (distance * (this.FuelConsumptionPerKm + 1.4));

            if (this.FuelQuantity - neededFuel >= 0)
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");
            }
        }


            public void DriveEmpty(double distance)
            {
                double consumedFuel = distance * this.FuelConsumptionPerKm;
                if (this.FuelQuantity - consumedFuel >= 0)
                {
                    Console.WriteLine($"Bus travelled {distance} km");
                    this.FuelQuantity -= consumedFuel;
                }
                else
                {
                    Console.WriteLine("Bus needs refueling");
                }
            }
            }
}
