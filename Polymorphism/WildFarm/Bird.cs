using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    abstract class Bird : Animal
    {
        public Bird(string animalType, string name, double weigth, double wingsize)
            : base(animalType, name, weigth)
        {
            this.WingSize = wingsize;
        }

        double WingSize { get; set; }
        public override string ToString()
        {
            return $"{AnimalType} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
