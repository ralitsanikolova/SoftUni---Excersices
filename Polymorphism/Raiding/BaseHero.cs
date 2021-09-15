using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    abstract class BaseHero
    {
        public string Name { get; set; }
        public int Power { get; set; }
     
        public abstract string CastAblility();
    }
}
