using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Cat : Feline
    {

        public Cat(string animalType, string name, string breed, double weigth, string livingRegion)
            : base(animalType, name, breed, weigth, livingRegion)
        {

        }
        public override void AnimalSound()
        {
            Console.WriteLine("Meow");
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegetable" || food.GetType().Name != "Meat")
            {

                Console.WriteLine($"{AnimalType} does not eat {food.GetType().Name}");
            }
            else
            {
                FoodEaten += food.Quantity;
                Weight += 0.35;
            }
        }
    }
}
