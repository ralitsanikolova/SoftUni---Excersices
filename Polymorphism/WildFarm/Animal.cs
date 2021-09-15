using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    abstract class Animal
    {
        public Animal(string animalType, string name, double weigth)
        {
            AnimalType = animalType;
            Name = name;
            Weight = weigth;
        }
        public string AnimalType { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public abstract void AnimalSound();
        public abstract void Eat(Food food);
    }
}
