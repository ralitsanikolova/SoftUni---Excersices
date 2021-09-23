using System;
using System.Collections.Generic;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            string animalInfo = Console.ReadLine();
            while (animalInfo != "End")
            {
                string[] inputAnimal = animalInfo.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string animalType = inputAnimal[0];
                string name = inputAnimal[1];
                double weigth = double.Parse(inputAnimal[2]);

                string[] foodInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string foodType = foodInput[0];
                int quantity = int.Parse(foodInput[1]);

                Food food = null;

                if (foodType == nameof(Vegetable))
                {
                    food = new Vegetable(quantity);
                }
                else if (foodType == nameof(Fruit))
                {
                    food = new Fruit(quantity);
                }
                else if (foodType == nameof(Meat))
                {
                    food = new Meat(quantity);
                }
                else if (foodType == nameof(Seeds))
                {
                    food = new Seeds(quantity);
                }

                Animal animal = null;
                if (animalType == "Cat" || animalType == "Tiger")
                {
                    string livingRegion = inputAnimal[3];
                    string breed = inputAnimal[4];

                    if (animalType == "Cat")
                    {
                        animal = new Cat(animalType, name, breed, weigth, livingRegion);
                        animal.AnimalSound();
                        animal.Eat(food);
                        Console.WriteLine(animal.ToString());
                    }
                    else if (animalType == "Tiger")
                    {
                        animal = new Tiger(animalType, name, breed, weigth, livingRegion);
                        animal.AnimalSound();
                        animal.Eat(food);
                        Console.WriteLine(animal.ToString());
                    }
                }
                else if (animalType == " Owl" || animalType == "Hen")
                {
                    double wingSize = double.Parse(inputAnimal[3]);
                    if (animalType == "Owl")
                    {
                        animal = new Owl(animalType, name, weigth, wingSize);
                        animal.AnimalSound();
                        animal.Eat(food);
                        Console.WriteLine(animal.ToString());
                    }
                    if (animalType == "Hen")
                    {
                        animal = new Hen(animalType, name, weigth, wingSize);
                        animal.AnimalSound();
                        animal.Eat(food);
                        Console.WriteLine(animal.ToString());
                    }
                }
                else if (animalType == "Mouse" || animalType == "Dog")
                {
                    string livingRegion = inputAnimal[3];

                    if (animalType == "Mouse")
                    {
                        animal = new Mouse(animalType, name, weigth, livingRegion);
                        animal.AnimalSound();
                        animal.Eat(food);
                        Console.WriteLine(animal.ToString());
                    }
                    if (animalType == "Dog")
                    {
                        animal = new Dog(animalType, name, weigth, livingRegion);
                        animal.AnimalSound();
                        animal.Eat(food);
                        Console.WriteLine(animal.ToString());
                    }
                }
                animalInfo = Console.ReadLine();
            }
        }
    }
}
