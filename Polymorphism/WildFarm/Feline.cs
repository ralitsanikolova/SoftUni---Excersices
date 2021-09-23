using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    abstract class Feline : Mammal
    {
        string Breed { get; set; }
        public Feline(string animalType, string name, string breed, double weigth, string livingRegion)
            : base(animalType, name, weigth, livingRegion)
        {
            this.Breed = breed;
        }
        public override string ToString()
        {
            return $"{AnimalType} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}

