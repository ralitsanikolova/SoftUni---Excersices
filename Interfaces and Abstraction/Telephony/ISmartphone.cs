using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    interface ISmartphone
    {
        public string Calling(string call);
        public string Browsing(string letter);
    }
}
