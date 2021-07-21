using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "Beast!")
            {
                try
                {
                    string type = Console.ReadLine();
                    string name = Console.ReadLine();
                    int age = int.Parse(Console.ReadLine());
                    string gender = Console.ReadLine();

                    Animal animal = new Animal(name, age, gender);

                    {
                        switch (input)
                        {
                            case "Dog":
                                Dog dog = new Dog(name, age, gender);
                                Console.WriteLine("Dog");
                                Console.WriteLine(animal.ProduceSound());
                                Console.WriteLine(dog.Result());
                                break;
                            case "Cat":
                                Cat cat = new Cat(name, age, gender);
                                Console.WriteLine("Cat");
                                Console.WriteLine(animal.ProduceSound());
                                Console.WriteLine(cat.Result());
                                break;
                            case "Frog":
                                Frog frog = new Frog(name, age, gender);
                                Console.WriteLine("Frog");
                                Console.WriteLine(animal.ProduceSound());
                                Console.WriteLine(frog.Result());
                                break;
                            case "Kitten":
                                Kitten kitten = new Kitten(name, age);
                                Console.WriteLine("Kitten");
                                Console.WriteLine(animal.ProduceSound());
                                Console.WriteLine(kitten.Result());
                                break;
                            case "Tomcat":
                                Tomcat tomcat = new Tomcat(name, age);
                                Console.WriteLine("Tomcat");
                                Console.WriteLine(animal.ProduceSound());
                                Console.WriteLine(tomcat.Result());
                                break;
                            default:
                                throw new ArgumentException("Invalid input!");
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}


