using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Telephony
{
    class StationaryPhone : IStationaryPhone
    {     
        public string Call { get; set; }
        public StationaryPhone()
        {
            
        }
        public string Calling(string number)
        {
            if (!Regex.IsMatch(number, @"^\d+$"))
            {
                return "Invalid number";    
            }
            else
            {
                return $"Dialing... {number}";
            }
        }
    }
}


