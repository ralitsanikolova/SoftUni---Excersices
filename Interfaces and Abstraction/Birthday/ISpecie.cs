using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday
{
    interface ISpecie
    {
        string ID { get; set; }
        DateTime BirthDate { get; set; }
    }
}
