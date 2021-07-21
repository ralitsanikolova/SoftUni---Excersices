using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Dessert : Food
    {
        public double calories;
        private double price;

        public Dessert(string name, decimal price, double grams, double calories) :
            base(name, price,grams)
        {
            Grams = grams;
            this.calories = calories;
            this.price = price;
        }

        public Dessert(string name, decimal price, double grams, double calories) :
           base(name, price, grams)
        {
            this.Calories = calories;
        }

        public double Calories
        {
            get
            {
                return this.calories; 
            }
            set 
            {
                this.calories = value;
            }
        }
    }

}
