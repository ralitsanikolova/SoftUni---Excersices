using System;

namespace ExplicitInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Citizen citizen = new Citizen
                {
                    Name = data[0],
                    Country = data[1],
                    Age = int.Parse(data[2]),
                };

                IPerson person = citizen;
                Console.WriteLine(person.Name);

                IResident resident = citizen;
                Console.WriteLine(resident.Name);
            }
        }
    }
}
