using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Cake: Dessert

    {
        static double grams = 250;
        static double calories = 1000;
        static double price = 22;

        public Cake(string name)
            : base(name,price, grams, calories)
        {
            this.Name = name;
        }
        public override double Grams { get => grams; }

       
    }
}
