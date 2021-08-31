using System;
using System.Collections.Generic;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISpecie> species = new List<ISpecie>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (data[0])
                {
                    case "Citizen":
                        if (data.Length == 5)
                        {
                            Citizen citizen = new Citizen()
                            {
                                Name = data[1],
                                Age = int.Parse(data[2]),
                                ID = data[3],
                                BirthDate = DateTime.ParseExact(data[4], "dd/MM/yyyy", null),
                            };
                            species.Add(citizen);
                        }
                        break;
                    case "Robot":
                        if (data.Length == 3)
                        {
                            Robot robot = new Robot()
                            {
                                Model = data[1],
                                ID = data[2]
                            };
                            species.Add(robot);
                        }
                        break;
                    case "Pet":
                        if (data.Length == 3)
                        {
                            Pet pet = new Pet()
                            {
                                Name = data[1],
                                BirthDate = DateTime.ParseExact(data[2], "dd/MM/yyyy", null),
                            };
                            species.Add(pet);
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            int finalInput = int.Parse(Console.ReadLine());

            foreach (var specie in species)
            {
                if (specie.BirthDate.Year == finalInput)
                {
                    Console.WriteLine(specie.BirthDate.Date.ToString("dd/MM/yyyy"));
                }
            }
        }
    }
}





