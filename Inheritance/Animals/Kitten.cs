﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Kitten : Cat
    {
        
        public Kitten(string name, int age)
            : base(name, age, "Female")
        {
            
        }
        public override string ProduceSound()
        {
            return "Meow";
        }
        public override string Result()
        {
            return base.Result() + ProduceSound();
        }
    }
}
