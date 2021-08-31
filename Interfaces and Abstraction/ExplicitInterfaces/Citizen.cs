using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    class Citizen : IPerson, IResident
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        string IPerson.GetName()
        {
            return Name;
        }
        string IResident.getName()
        {
            return "Mr/Ms/Mrs " + Name;
        }
    }
}
