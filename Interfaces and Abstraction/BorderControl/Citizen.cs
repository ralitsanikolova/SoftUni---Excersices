using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
   public class Citizen : ISpecie
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
