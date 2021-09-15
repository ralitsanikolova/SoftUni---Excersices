using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseHero> raidGroup = new List<BaseHero>();
            
            int input = int.Parse(Console.ReadLine());
            int countValidHeroes = 0;

            BaseHero hero;
            while(countValidHeroes != input)
            {

                string name = Console.ReadLine();
                string heroType = Console.ReadLine();
             

                switch (heroType)
                {
                    case "Druid":
                        hero = new Druid(name);
                        break;
                    case "Paladin":
                        hero = new Paladin(name);
                       
                        break;
                    case "Rogue":
                        hero = new Rogue(name);
                       
                        break;
                    case "Warrior":
                        hero = new Warrior(name);
                        
                        break;
                    default:
                        throw new ArgumentException("Invalid hero!");
                }
                countValidHeroes++;
                raidGroup.Add(hero);
            }

            int bossPower = int.Parse(Console.ReadLine());

            for (int i = 0; i < raidGroup.Count; i++)
            {
                BaseHero heroN = raidGroup[i];
                Console.WriteLine(heroN.CastAblility());
            }

           
            int heroesPower = raidGroup.Select(hero => hero.Power).Sum();

            if(heroesPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
