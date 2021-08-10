using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Food : Product
    { 
        public Food(string name, decimal price, double grams)
            : base(name,price)
        {
            Name = name;
            Price = price;
            this.Grams = grams;
        }

        public virtual double Grams
        {
            get
            {
                return this.Grams;
            }
            set
            {
                this.Grams = value;
            }
        }
    }
}
