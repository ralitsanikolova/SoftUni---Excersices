using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Fish : MainDish
    {
        static double grams = 22;

        public Fish(string name, decimal price, double grams)
            : base(name, price, 0)
        {

        }

        public override double Grams { get => grams; }
    }
}
