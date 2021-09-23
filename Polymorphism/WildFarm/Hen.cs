using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Hen : Bird
    {
        public Hen(string animalType, string name, double weigth, double wingsize)
            : base(animalType, name, weigth, wingsize)
        {
        }
        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Fruit" || food.GetType().Name == "Vegetable" || food.GetType().Name == "Meat")
            {
                Weight += 0.35;

                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{AnimalType} does not eat {food.GetType().Name}");
            }
        }
        public override void AnimalSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
