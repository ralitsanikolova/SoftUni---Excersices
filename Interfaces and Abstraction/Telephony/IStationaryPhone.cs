using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    interface IStationaryPhone
    {
        string Call { get; set; }
        public string Calling(string number);
    }
}
