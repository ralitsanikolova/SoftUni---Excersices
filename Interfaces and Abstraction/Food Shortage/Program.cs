using System;
using System.Collections.Generic;
using System.Linq;

namespace Food_Shortage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();

            int numberOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i <= numberOfPeople; i++)
            {
                string[] data = Console.ReadLine().Split();

                if (data.Length == 4)
                {
                    Citizen citizen = new Citizen()
                    {
                        Name = data[0],
                        Age = int.Parse(data[1]),
                        ID = data[2],
                        Birthdate = data[3]
                    };
                    citizens.Add(citizen);
                }
                else if (data.Length == 3)
                {
                    Rebel rebel = new Rebel()
                    {
                        Name = data[0],
                        Age = int.Parse(data[1]),
                        Group = data[2]
                    };
                    rebels.Add(rebel);
                }
            }

            string buyer;
            while ((buyer = Console.ReadLine()) != "End")
            {
                Citizen citizenBuyer = citizens.FirstOrDefault(citizen => citizen.Name == buyer);
                Rebel rebelBuyer = rebels.FirstOrDefault(rebel => rebel.Name == buyer);
                if (citizenBuyer != null)
                {
                    citizenBuyer.BuyFood();
                }
                if (rebelBuyer != null)
                {
                    rebelBuyer.BuyFood();
                }
            }
            Console.WriteLine(citizens.Sum(buyC => buyC.Food) + rebels.Sum(buyR => buyR.Food));
        }
    }
}
