using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{

    class Citizen : IIdentifiable, IBirthable
    {
        public Citizen(string name, int age, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthdate;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthdate { get; set; }
        public string Id { get; set; }
    }
}
    

