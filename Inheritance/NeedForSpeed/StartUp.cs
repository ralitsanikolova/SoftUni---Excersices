using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int horsePower = int.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());

            Vehicle vehicle = new Vehicle(horsePower, fuel);
            Console.WriteLine(vehicle);
            Console.WriteLine($"Left fuel: {fuel}");

        }
    }
}

