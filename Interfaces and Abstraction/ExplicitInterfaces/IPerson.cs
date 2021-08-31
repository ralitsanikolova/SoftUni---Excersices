using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
        string GetName();
    }
}
