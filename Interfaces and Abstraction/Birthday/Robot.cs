using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday
{
    class Robot : ISpecie
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
