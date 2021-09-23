using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    class Owl : Bird
    {
        public Owl(string animalType, string name, double weigth, double wingsize)
           : base(animalType, name, weigth, wingsize) { }
        public override void AnimalSound()
        {
            Console.WriteLine($"Hoot Hoot");
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
                Weight += 0.25;
            }
        }
    }
}
