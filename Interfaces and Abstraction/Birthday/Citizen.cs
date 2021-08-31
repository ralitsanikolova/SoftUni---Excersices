﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday
{
     public class Citizen : ISpecie
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
