using System;

namespace Zoo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Animal animal = new Animal(name);
            Console.WriteLine(animal);
        }
    }
}
