﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday
{
    class Pet : ISpecie
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public DateTime BirthDate { get; set; }    
    }
}
