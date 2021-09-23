using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class Paladin : BaseHero
    {
        public Paladin(string name) 
        {
            Name = name;
        }
         int Power = 100;
        
        public override string CastAblility()
        {
            return $"{GetType().Name} - {Name} healed for {Power}";
        }
    }
}
