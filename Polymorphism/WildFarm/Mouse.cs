using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Mouse : Mammal
    {
        public Mouse(string animalType, string name, double weigth, string livingRegion)
            : base(animalType, name, weigth, livingRegion)
        {

        }
        public override void AnimalSound()
        {
            Console.WriteLine("Squeak");
        }
        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegetable" || food.GetType().Name != "Fruit")
            {
                Console.WriteLine($"{AnimalType} does not eat {food.GetType().Name}");

            }
            else
            {
                FoodEaten += food.Quantity;
                Weight += 0.10;
            }
        }
        public override string ToString()
        {
            return $"{AnimalType} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
