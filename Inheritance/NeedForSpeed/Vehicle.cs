using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    class Vehicle
    {
        public int HorsePower { get; set; }
        public double Fuel { get; set; }

        public double DefaultFuelComsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
        public virtual double FuelConsumption
        {
            get
            {
                return DefaultFuelComsumption;
            }
        }
        public virtual void Drive(double kilometers)
        {
             Fuel -= FuelConsumption * kilometers;
        }
        

       
    }
}
