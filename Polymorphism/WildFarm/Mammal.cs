using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    abstract class Mammal : Animal
    {

        public Mammal(string animalType, string name, double weigth, string livingRegion)
            : base(animalType, name, weigth)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; set; }

        public override string ToString()
        {
            return $"{this.AnimalType}, {Name}, {Weight}, {LivingRegion}] ";
        }
    }
}
