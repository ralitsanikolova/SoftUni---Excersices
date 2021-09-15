using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class Druid : BaseHero
    {
        public Druid(string name)
        {
            Name = name;
        }

        int Power = 80;
        public override string CastAblility()
        {
            return $"{GetType().Name} - {Name} healed for {Power}";
        }
    }
}
