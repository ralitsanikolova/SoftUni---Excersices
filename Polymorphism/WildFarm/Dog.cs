using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Dog : Mammal
    {
        public Dog(string animalType, string name, double weigth, string livingRegion)
            : base(animalType, name, weigth, livingRegion)
        { 
        }

        public override void AnimalSound()
        {
            Console.WriteLine("Woof");
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                Console.WriteLine($"{AnimalType} does not eat {food.GetType().Name}");
            }
            else
            {
                FoodEaten += food.Quantity;
                Weight += 0.40;
            }
        }
        public override string ToString()
        {
            return $"{AnimalType} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
