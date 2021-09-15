using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class Rogue : BaseHero
    {
        public Rogue(string name)
        {
            Name = name;
        }
        int Power = 80;
        public override string CastAblility()
        {
            return $"{GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}
