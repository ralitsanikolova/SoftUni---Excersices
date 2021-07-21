using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Beverage : Product
    {
        private double milliliters;

        public Beverage(string name, decimal price, double milliliters)
            :base (name, price)
        {
           this.Milliliters = milliliters;
        }

        public virtual double Milliliters
        {
            get
            {
                return this.milliliters;
            }
            set
            {
                this.milliliters = value;
            }
        }
        }
    }

