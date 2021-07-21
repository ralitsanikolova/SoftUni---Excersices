using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, "Male")
        {
            base.Name = name;
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
        public override string Result()
        {
            return base.Result() + ProduceSound();
        }
    }
}
