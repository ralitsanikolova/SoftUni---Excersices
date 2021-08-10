using System;
using System.Collections.Generic;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISpecie> species = new List<ISpecie>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (data.Length == 3)
                {
                    Citizen citizen = new Citizen()
                    {
                        Name = data[0],
                        Age = int.Parse(data[1]),
                        ID = data[2]
                    };
                    species.Add(citizen);
                }
                if (data.Length == 2)
                {
                    Robot robot = new Robot()
                    {
                        Model = data[0],
                        ID = data[1]
                    };
                    species.Add(robot);
                }
            }
            string finalInput = Console.ReadLine();

            foreach (ISpecie specie in species)
            {
                if (specie.ID.EndsWith(finalInput))
                {
                    Console.WriteLine(specie.ID);
                }
            }
        }
    }
}
