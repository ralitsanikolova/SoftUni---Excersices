using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Coffee : HotBeverage
    {
        double caffeine;
        static double milliliters = 50;
        static double price = 3.50;

        public Coffee(string name, decimal price, double milliliters)
          : base(name, price, milliliters)
        {
            this.Caffeine = caffeine;
        }

        public override double Milliliters { get => base.Milliliters;}
       

        public double Caffeine
        {
            get
            {
                return this.caffeine
            }
            set
            {
                this.caffeine = value
            }
        }
    }
}
