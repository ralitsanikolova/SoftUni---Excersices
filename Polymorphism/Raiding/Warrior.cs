using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class Warrior: BaseHero
    {
        public Warrior(string name)
        {
            Name = name;
        }

        int Power = 100;
        public override string CastAblility()
        {
            return $"{GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}
