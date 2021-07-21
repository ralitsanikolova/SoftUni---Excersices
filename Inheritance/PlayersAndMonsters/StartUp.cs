using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int level = int.Parse(Console.ReadLine());

            Hero hero = new Hero(username,level);
            Console.WriteLine(hero);
        }
    }
}
