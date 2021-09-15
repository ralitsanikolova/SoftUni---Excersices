using System;
using System.Collections.Generic;

namespace Vehicles_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicle = new List<Vehicle>();

            string[] inputCar = Console.ReadLine().Split(' ');
            Car car = new Car()
            {
                TypeVehicle = inputCar[0],
                FuelQuantity = double.Parse(inputCar[1]),
                FuelConsumptionPerKm = double.Parse(inputCar[2])

            };
            vehicle.Add(car);

            string[] inputTruck = Console.ReadLine().Split(' ');
            Truck truck = new Truck()
            {
                TypeVehicle = inputTruck[0],
                FuelQuantity = double.Parse(inputCar[1]),
                FuelConsumptionPerKm = double.Parse(inputCar[2])
            };
            vehicle.Add(truck);

            string[] inputBus = Console.ReadLine().Split(' ');
            Bus bus = new Bus()
            {
                TypeVehicle = inputTruck[0],
                FuelQuantity = double.Parse(inputCar[1]),
                FuelConsumptionPerKm = double.Parse(inputCar[2])
            };
            vehicle.Add(bus);

            int inputCommand = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputCommand; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string typeVehicle = input[1];

                switch (command)
                {
                    case "Drive":
                        double distance = double.Parse(input[2]);

                        if (typeVehicle == "Car")
                        {
                            car.DriveVehicle(distance);

                        }
                        else if (typeVehicle == "Truck")
                        {
                            truck.DriveVehicle(distance);
                        }
                        break;
                    case "Refuel":
                        double liters = double.Parse(input[2]);
                        if (typeVehicle == "Car")
                        {
                            car.Refuel(liters);
                        }
                        else if (typeVehicle == "Truck")
                        {
                            truck.Refuel(liters);
                        }
                        break;
                    case "Drive empty":
                        double busDistance = double.Parse(input[2]);
                        bus.DriveEmpty(busDistance);
                        break;
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}


