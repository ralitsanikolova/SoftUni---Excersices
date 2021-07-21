using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name {0}",
                this.Name));

            return stringBuilder.ToString();
        }
    }
}
